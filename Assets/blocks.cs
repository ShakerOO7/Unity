using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocks : MonoBehaviour
{
    // Start is called before the first frame update
	public GameObject cube, block;
	public Material mat;
    float time;
    void Start()
    {
        //Create();
    }

    // Update is called once per frame
    void Update()
    {
        //time += Time.deltaTime;
        //if (time > 1)
        //{
        //    Create();
        //}
    }

    public void Create()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = block.transform.position;
        cube.AddComponent<Rigidbody>();
        cube.GetComponent<Rigidbody>().useGravity = true;
        time = Time.deltaTime;
        cube.GetComponent<Renderer>().material = mat;
        switch (Random.Range(1, 3))
        {
            case 1:
                cube.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                break;
            case 2:
                cube.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
                break;
        }
        
    }
}
