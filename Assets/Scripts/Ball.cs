using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] AudioSource _ballSound;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed = 4f;
    [SerializeField] private Vector2[] _startDirection;  
    void Start()
    {
        int selectDir = Random.Range(0,3);

        _rb.velocity = _startDirection[selectDir] * _speed;
    }
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("LeftBorder") && !collision.gameObject.CompareTag("RightBorder"))
        {
            _ballSound.Play();
        }
        
        if (collision.gameObject.CompareTag("LeftBorder"))
        {
            GameObject.FindAnyObjectByType<GameController>().AddScore(false);
        }
        if (collision.gameObject.CompareTag("RightBorder"))
        {
            GameObject.FindAnyObjectByType<GameController>().AddScore(true);
        }
    }
    
}
