using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    // public Rigidbody rb;
    // public GameObject fv;
    public float speed = -5f;
    
    void Start()
    {
       // rb = GetComponent<Rigidbody>();
        
    }
    void Update()
    {
        transform.Translate(speed*Time.deltaTime, 0, 0);
       
    }

   // void FixedUpdate()
    //{
        
         

   // }
}