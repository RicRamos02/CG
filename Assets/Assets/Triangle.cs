using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    Mesh mesh;
    MeshRenderer meshRenderer;
    Vector3[] vertices;
    int[] triangles;
    Color32[] colors;
    public Material material;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = material;
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        vertices = new[] {
            new Vector3(0,0,0),
            new Vector3(0,1,0),
            new Vector3(1,0,0),
            new Vector3(3,0,0),
            new Vector3(3,1,0),
            new Vector3(4,0,0),
        };

        mesh.vertices = vertices;
        triangles = new[]{0,1,2,3,4,5};
        mesh.triangles = triangles;

        colors = new Color32[vertices.Length];

        for (int i = 0; i < vertices.Length; i += 3){

        colors[i] = new Color32(255, 0, 0, 255);
        colors[i + 1] = new Color32(0, 255, 0, 255);
        colors[i + 2] = new Color32(0, 0, 255, 255);

        }
        
        mesh.colors32 = colors;
        material = GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
