using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerComponent : MonoBehaviour
{
    [SerializeField] private GameObject _bottleGrow;
    private float _placeToSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnBottle();
    }

    // Update is called once per frame
    public void SpawnBottle()
    {
        _placeToSpawn = Random.Range(-3, 3)+0.5f;
        Instantiate(_bottleGrow, new Vector3(_placeToSpawn, -15, 0), Quaternion.identity);
    }
}
