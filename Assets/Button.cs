using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    GameObject[] mShip;
    public int shipCount = 20, last = 0;
    public Rigidbody Ship;
    public GameObject Source, Target;
    public float Speed = 5.0f;
    bool Click = false;

    void Start()
    {
        mShip = new GameObject[12000];
    }

    public void OnClick()
    {
        Click = true;
        last = last % 10000;
        for(int i = 0; i  < shipCount; i++,last++)
        {
            //Debug.Log(last);
            GetShip(last);
        }
    }

    void Update()
    {
        if (Click)
        {
            for (int i = 0; i < 10000; i++)
            {
                if (mShip[i] != null)
                {
                    mShip[i].GetComponent<Rigidbody>().velocity = (Target.transform.position
                            - mShip[i].transform.position).normalized * Speed;
                }
            }
                
        }
    }

    void GetShip(int i)
    {
        mShip[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        mShip[i].GetComponent<Renderer>().material = Ship.GetComponent<Renderer>().material;
        mShip[i].transform.localScale = Ship.transform.localScale;
        mShip[i].transform.position = Source.transform.position;
        mShip[i].AddComponent<Collider>();
        mShip[i].AddComponent<Rigidbody>();
        mShip[i].GetComponent<Rigidbody>().useGravity = false;
        mShip[i].GetComponent<Rigidbody>().velocity = (Target.transform.position
            - mShip[i].transform.position).normalized * Speed;
    }
}
