using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleComponent : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private SpawnerComponent _spawner;
    private WallComponent _wallComponent;
    private bool _isSpawning;
    private WorldVariables WV;
    
    void Start()
    {
        _player = FindObjectOfType<MovementComponent>().gameObject;
        _spawner = FindObjectOfType<SpawnerComponent>();
        _wallComponent = FindObjectOfType<WallComponent>();
        WV = FindObjectOfType<WorldVariables>();
        _isSpawning = true;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.up*Time.deltaTime*WV.Speed);
        if (gameObject.transform.position.y > 15) Destroy(gameObject);
        if (_isSpawning)
        {
            if (gameObject.transform.position.y > _player.transform.position.y)
            {
                _spawner.SpawnBottle();
                _isSpawning = false;
            }
        }
    }
}
