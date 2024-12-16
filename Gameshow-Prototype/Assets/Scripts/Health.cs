using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxhealth = 1;
    public int currenthealth;
    
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxhealth;
    }
    
    public void takedamage(int amount)
    {
        currenthealth -= amount;

        if(currenthealth <= 0)
        {
            SceneManager.LoadScene("Demo1");
        }
    }
    
 
}
