using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;
    private bool _isPressingUp;
    private bool _isPressingDown;
    [SerializeField] private bool _isPlayerOne;
    
    void Start()
    {
        
    }
    void Update()
    {

        if (_isPlayerOne)
        {
            _isPressingUp = Input.GetKey(KeyCode.UpArrow);
            _isPressingDown = Input.GetKey(KeyCode.DownArrow);
        }
        else
        {
            _isPressingUp = Input.GetKey(KeyCode.W);
            _isPressingDown = Input.GetKey(KeyCode.S);
        }

        if (_isPressingUp)
        {
            transform.Translate(Vector2.up * _moveSpeed * Time.deltaTime);
        }
        if (_isPressingDown)
        {
            transform.Translate(Vector2.down * _moveSpeed * Time.deltaTime);
        }
        
    }
}
