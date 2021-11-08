using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTileMesh : MonoBehaviour
{
    //private TileMesh mesh;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshFilter>().mesh = MeshUtils.CreateTileMesh();

        //mesh = new TileMesh();
        //GetComponent<MeshFilter>().mesh = mesh.CreateTileMesh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//https://docs.unity3d.com/ScriptReference/Material-ctor.html