using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OgólneŻarełko : MonoBehaviour
{


    public virtual void Zapapiono()
    {
        Debug.Log("Debug.Log czyli Derobak.kłoda");
        Destroy(this.gameObject);
    }

    // Useless Text 2D
    void Start()
    {
        
    }

    // Second Useless Text 3D
    void Update()
    {
        
    }
}
