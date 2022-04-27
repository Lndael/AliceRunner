using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallComponent : MonoBehaviour
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
       
        gameObject.GetComponent<Renderer>().material.mainTextureOffset -= new Vector2(0,0.1f*WV.Speed*Time.deltaTime);
        
    }
}
