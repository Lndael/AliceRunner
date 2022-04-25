using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallComponent : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _wall;
    public float speed;
    private bool _isSpawning;
    
    void Start()
    {
        speed = 1f;
        _isSpawning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isSpawning)
        {
            if (gameObject.transform.position.y > 0)
            {
                Instantiate(_wall, new Vector3(transform.position.x, -15f, 0), Quaternion.identity);
                _isSpawning = false;
            }
        }

        gameObject.transform.Translate(Vector3.up*speed*Time.deltaTime);
        
        if (gameObject.transform.position.y > 15)
        {
            Destroy(gameObject);
        }
    }
}
