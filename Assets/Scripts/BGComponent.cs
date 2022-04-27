using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGComponent : MonoBehaviour
{
    // Start is called before the first frame update
    private WorldVariables WV;

    void Start()
    {
        WV = FindObjectOfType<WorldVariables>();
    }

    // Update is called once per frame
    void Update()
    {
        
        gameObject.GetComponentInChildren<Renderer>().material.mainTextureOffset -= new Vector2(0,0.1f*WV.Speed/2*Time.deltaTime);

    }
}
