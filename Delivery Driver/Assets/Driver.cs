using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 140;
    [SerializeField] float boostSpeed = 25; 
    [SerializeField] float bumpSpeed = 8;
    [SerializeField] float moveSpeed = 15;
    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        float steerAmount = Input.GetAxis ("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime;
        
        if  (moveAmount>0)
        {
        transform.Rotate (0,0,-steerAmount);
        }
        transform.Translate (0,moveAmount,0);
    }

     void OnTriggerEnter2D(Collider2D other)
    
    {
      if (other.tag == "Boost")
      moveSpeed = boostSpeed;

     

      if (other.tag == "Bump")
      moveSpeed = bumpSpeed;
    }
}
