using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundpostion : MonoBehaviour
{
    public Transform ground;

  
    private void FixedUpdate()
    {
        ground.transform.position = new Vector3(ground.gameObject.transform.position.x, ground.gameObject.transform.position.y, this.transform.position.z);
    }
}
