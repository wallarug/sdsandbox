 using UnityEngine;
 using System.Collections;
 

 public class ToggleLights : MonoBehaviour
 {
     public static int LightState = 0;
     void Start()
     {
     }
 
     void Update()
     {
         if (Input.GetKeyDown(KeyCode.E)){
             LightState++;
             if(LightState > 3){
                 LightState = 0;
             }
        }
     }  

 }