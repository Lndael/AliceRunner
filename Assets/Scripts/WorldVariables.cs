using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class WorldVariables : MonoBehaviour
{
    [SerializeField] private float _speed;
    public float Speed
    {
        get => _speed;
        set => _speed = value;
    }

    void Start()
    {
        Speed = 1;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
