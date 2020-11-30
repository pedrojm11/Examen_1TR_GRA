using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float myspeed;
    // Start is called before the first frame update
    void Start()
    {
        myspeed=2.5f;
    }

    // Update is called once per frame
    void Update()
    {
       Moverbola();
    }
    void Moverbola()
    {
        float desplZ = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * myspeed * desplZ);
        float desplX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * myspeed * desplX);
        float PosX = transform.position.x;
        float PosZ = transform.position.z;
        if (PosX > -4.8 && PosX < 4.8)
        {
            transform.Translate(Vector3.right * Time.deltaTime * myspeed * desplX);
        }
        else if (PosX < -4 && desplX > 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * myspeed * desplX);
        }
        else if (PosX > 4 && desplX < -0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * myspeed * desplX);
        }



    }
    
}


   

