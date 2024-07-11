using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _width = 6f;
    private SpriteRenderer _renderer;
    private Vector2 _startsize;


  
   

    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        
        _startsize = new Vector2(_renderer.size.x, _renderer.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        _renderer.size = new Vector2(_renderer.size.x + _speed*Time.deltaTime, _renderer.size.y);
        if (_renderer.size.x > _width) 
        {
            _renderer.size = _startsize;
        }
    }
}
