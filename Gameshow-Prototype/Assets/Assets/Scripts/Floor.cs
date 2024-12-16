using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Finish"))
        {
            HealthSystemForDummies healthSystem = collision.gameObject.GetComponent<HealthSystemForDummies>();
            //this is for destroying the ball
            healthSystem.AddToCurrentHealth(-1);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
