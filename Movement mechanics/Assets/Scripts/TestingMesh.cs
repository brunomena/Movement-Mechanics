using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMesh : MonoBehaviour
{
    public Material[] mat;

    // Start is called before the first frame update
    void Start()
    {
        CreateTileMesh();
    }

    private void CreateBasicQuadMesh ()
    {
        mat = GetComponent<Renderer>().materials;
        Mesh mesh = new Mesh();

        Vector3[] vertices = new Vector3[4];
        Vector2[] uv = new Vector2[4];
        int[] triangles = new int[6];

        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0, 0, 10);
        vertices[2] = new Vector3(10, 0, 10);
        vertices[3] = new Vector3(10, 0, 0);

        uv[0] = new Vector2(0, 0);
        uv[1] = new Vector2(0, 1);
        uv[2] = new Vector2(1, 1);
        uv[3] = new Vector2(1, 0);

        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;
        triangles[3] = 0;
        triangles[4] = 2;
        triangles[5] = 3;

        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<Renderer>().material = mat[0];

    }

    private void CreateTileMesh()
    {

        int width = 3;
        int heigth = 3;
        float tileSize = 1;

        mat = GetComponent<Renderer>().materials;
        Mesh mesh = new Mesh();

        Vector3[] vertices = new Vector3[4* (width*heigth)];
        Vector2[] uv = new Vector2[4 * (width * heigth)];
        int[] triangles = new int[6 * (width * heigth)];

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < heigth; j++)
            {

                int index = i * heigth + j;

                vertices[index *4 + 0] = new Vector3(tileSize * i, 0,            tileSize * j);
                vertices[index * 4 + 1] = new Vector3(tileSize * i, 0,            tileSize * (j + 1));
                vertices[index * 4 + 2] = new Vector3(tileSize * (i + 1), 0,      tileSize * (j + 1));
                vertices[index * 4 + 3] = new Vector3(tileSize * (i + 1), 0,      tileSize * j);

                uv[index * 4 + 0] = new Vector2(0, 0);
                uv[index * 4 + 1] = new Vector2(0, 1);
                uv[index * 4 + 2] = new Vector2(1, 1);
                uv[index * 4 + 3] = new Vector2(1, 0);

                triangles[index * 6 + 0] = index * 4 + 0;
                triangles[index * 6 + 1] = index * 4 + 1;
                triangles[index * 6 + 2] = index * 4 + 2;
                triangles[index * 6 + 3] = index * 4 + 0;
                triangles[index * 6 + 4] = index * 4 + 2;
                triangles[index * 6 + 5] = index * 4 + 3;

            }

        }

        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<Renderer>().material = mat[0];


    }

}

//Classe para criar mesh e escolehr material dessa mesh
//public Material[] mat;

//// Start is called before the first frame update
//void Start()
//{
//    mat = GetComponent<Renderer>().materials;
//    Mesh mesh = new Mesh();

//    Vector3[] vertices = new Vector3[4];
//    Vector2[] uv = new Vector2[4];
//    int[] triangles = new int[6];

//    vertices[0] = new Vector3(0, 0, 0);
//    vertices[1] = new Vector3(0, 0, 10);
//    vertices[2] = new Vector3(10, 0, 10);
//    vertices[3] = new Vector3(10, 0, 0);

//    uv[0] = new Vector2(0, 0);
//    uv[1] = new Vector2(0, 1);
//    uv[2] = new Vector2(1, 1);
//    uv[3] = new Vector2(1, 0);

//    triangles[0] = 0;
//    triangles[1] = 1;
//    triangles[2] = 2;
//    triangles[3] = 0;
//    triangles[4] = 2;
//    triangles[5] = 3;

//    mesh.vertices = vertices;
//    mesh.uv = uv;
//    mesh.triangles = triangles;

//    GetComponent<MeshFilter>().mesh = mesh;
//    GetComponent<Renderer>().material = mat[0];
//}

//// Update is called once per frame
//void Update()
//{

//}