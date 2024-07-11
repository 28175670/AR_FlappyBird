using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.XR.ARCore;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARFaceManager))]
[RequireComponent(typeof(ARSessionOrigin))]
public class NoseTipManager : MonoBehaviour
{
    private ARFaceManager mARFaceManager;
    public GameObject mInstantiatedPrefab;
    private ARSessionOrigin mSessionOrigin;
    private NativeArray<ARCoreFaceRegionData> mFaceRegions;
    private void Awake()
    {
        mARFaceManager = GetComponent<ARFaceManager>();
        mSessionOrigin = GetComponent<ARSessionOrigin>();

    }
    private void OnEnable()
    {
        mARFaceManager.facesChanged += OnFacesChanged;
    }
    void OnDisable()
    {
        mARFaceManager.facesChanged -= OnFacesChanged;
    }
    void OnFacesChanged(ARFacesChangedEventArgs eventArgs)
    {
        foreach (var trackedFace in eventArgs.added)
        {
            OnFaceChanged(trackedFace);
        }

        foreach (var trackedFace in eventArgs.updated)
        {
            OnFaceChanged(trackedFace);
        }
    }
    private void OnFaceChanged(ARFace refFace)
    {
        var subsystem = (ARCoreFaceSubsystem)mARFaceManager.subsystem;
        subsystem.GetRegionPoses(refFace.trackableId, Allocator.Persistent, ref mFaceRegions);
        for (int i = 0; i < mFaceRegions.Length; ++i)
        {
            var regionType = mFaceRegions[i].region;
            if (regionType == ARCoreFaceRegion.NoseTip)
            {
                mInstantiatedPrefab.transform.localPosition = mFaceRegions[i].pose.position;
                mInstantiatedPrefab.transform.localRotation = mFaceRegions[i].pose.rotation;
            }
        }
    }
    void OnDestroy()
    {
        if (mFaceRegions.IsCreated)
            mFaceRegions.Dispose();
    }
}



