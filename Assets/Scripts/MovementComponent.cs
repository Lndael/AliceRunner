using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Texture[] _texture;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            _player.transform.Translate(Vector3.right/5);
            _player.GetComponent<Renderer>().material.mainTexture = _texture[1];
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            _player.transform.Translate(Vector3.left/5);
            _player.GetComponent<Renderer>().material.mainTexture = _texture[0];
        }

        if (_player.transform.position.x > 2.5)
            _player.transform.position = Vector3.right*2.5f + Vector3.up*4;
        if (_player.transform.position.x < -2.5)
            _player.transform.position = Vector3.left*2.5f + Vector3.up*4;
        

    }
}
