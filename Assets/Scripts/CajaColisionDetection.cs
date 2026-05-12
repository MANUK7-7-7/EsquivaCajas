using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaColisionDetection : MonoBehaviour
{
    public CajaMovement cajaMovementScript;

    
    
     void Start()
    {
      cajaMovementScript = GetComponent<CajaMovement>();  
    }

     void OnCollisionEnter(Collision col)
     {
        if(col.gameObject.CompareTag("piso")){
          cajaMovementScript.AumentarVelocidad(0.2f);
         cajaMovementScript.MoveBoxToRandomPosition();
          
   
        }
     }
}
