using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }   [SerializeField] float MoveSpeed = 12;
        [SerializeField] float SteerSpeed = 140;
        
    // Update is called once per frame
    void Update()
    {   
        float MoveAmount =  Input.GetAxis ("Vertical") * MoveSpeed * Time.deltaTime;
        float SteerAmount = - Input.GetAxis ("Horizontal") * SteerSpeed * Time.deltaTime;
        
        transform.Translate (0,MoveAmount,0);
        transform.Rotate (0,0,SteerAmount);
       
    
    }
}
