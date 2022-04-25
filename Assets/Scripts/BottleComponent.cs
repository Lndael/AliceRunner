using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleComponent : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private SpawnerComponent _spawner;
    private float speed;
    private WallComponent _wallComponent;
    
    void Start()
    {
        _player = FindObjectOfType<MovementComponent>().gameObject;
        _spawner = FindObjectOfType<SpawnerComponent>();
        _wallComponent = FindObjectOfType<WallComponent>();
        speed = _wallComponent.speed;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.up*Time.deltaTime*speed);
        if (gameObject.transform.position.y > 15) Destroy(gameObject);
        if (gameObject.transform.position.y > _player.transform.position.y) _spawner.SpawnBottle();
    }
}
