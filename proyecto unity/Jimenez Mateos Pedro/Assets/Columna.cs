using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columna : MonoBehaviour
{
    public float mySpeed;
    // Start is called before the first frame update
    void Start()
    {
        mySpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void MovimientoColumna()
    {
        transform.Translate(Vector3.back * Time.deltaTime * mySpeed);
        if (transform.position.y > 25)
        {
            Destroy(gameObject);
        }
    }
}


