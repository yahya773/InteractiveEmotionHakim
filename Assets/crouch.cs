using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouch : MonoBehaviour
{
    public CharacterController PlayerHeight;
    public float normalHeight, crouchHeight;
    
    void Update(){
        if(Input.GetKeyDown(KeyCode.C)){
            PlayerHeight.height = crouchHeight;  
        }
        if(Input.GetKeyDown(KeyCode.C)){
             PlayerHeight.height = normalHeight;
        }   
    }
    
        
    
}
