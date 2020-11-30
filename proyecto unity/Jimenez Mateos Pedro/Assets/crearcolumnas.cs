using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearcolumnas : MonoBehaviour
{
    [SerializeField] Transform Cylinder;
    [SerializeField] Transform RefPos;
    [SerializeField] float distobstacle;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ColumnCorrutine");
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            CrearColumna();
        }
    }
    void CrearColumna()
    {
       
        float posRandom = Random.Range(0f, 30f);
       
        Vector3 DestPos = new Vector3(0, 0, posRandom);
       
        Vector3 NewPos = RefPos.position + DestPos;
        
        Instantiate(Cylinder, NewPos, Quaternion.identity);
    }
    
    IEnumerator ColumnCorrutine()
    {
        
        for (int n = 0; ; n++)
        {
            
            print(n);
            
            
            CrearColumna();
            
            yield return new WaitForSeconds(1);
        }
    }

 
}
