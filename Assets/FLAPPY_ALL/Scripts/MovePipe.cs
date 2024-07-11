using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] private float _speed = 0.65f;
    // Start is called before the first frame update


    
    private void Update()
    {
        transform.position += Vector3.left* _speed * Time.deltaTime;
    }
}
