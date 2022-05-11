using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
 
     [SerializeField] Color hasPackageColor = new Color (1,1,1,1);
     [SerializeField] Color noPackageColor = new Color (1,1,1,1);
     [SerializeField] float destroyDelay = 0.2f;
      
     
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }
     bool hasPackage;

     void OnCollisionEnter2D(Collision2D other) 
        {
            Debug.Log ("Ouch!!");
        }
           
                  
         
         
      void OnTriggerEnter2D(Collider2D other) 
    {
        
          if (other.tag == "Package" && !hasPackage)
           //"! mark means not" 
            
        {
            Debug.Log ("Package picked up"); 
           
            hasPackage = true;
            
            spriteRenderer.color = hasPackageColor;
             
            Destroy (other.gameObject,destroyDelay); 
             
            
          
        }                 
          
            
        
            if (other.tag == "Customer" && hasPackage)
       
        {
            Debug.Log ("Package Delivered");

            spriteRenderer.color = noPackageColor;

            hasPackage = false;
        }
    }
}
       
              
        

     

    
        
    

