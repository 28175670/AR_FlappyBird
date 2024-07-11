using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRangeX = 0.45f;
    [SerializeField] private float _heightRangeY = 0.45f;
    [SerializeField] private GameObject _Pipe;
    [SerializeField] public Transform _PipeTransform;
    //[SerializeField] public float _sPipeTransform;

    private float _timer;
    // Start is called before the first frame update
    private void Start()
    {
       SpawnPipe();
    }

    // Update is called once per frame
    private void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }
    private void SpawnPipe()
    {
        Vector3 spawnpos = new Vector3(0, Random.Range(-_heightRangeX, _heightRangeY), _PipeTransform.position.z) + this.transform.position;
        GameObject pipe = Instantiate(_Pipe, spawnpos, Quaternion.identity);

        Destroy(pipe, 25f);
    }
}
