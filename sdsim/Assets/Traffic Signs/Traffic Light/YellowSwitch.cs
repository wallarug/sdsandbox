using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowSwitch : MonoBehaviour
{
    public Material[] materials = new Material[2];
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        int state = ToggleLights.LightState;
        if(state == 2){
            rend.sharedMaterial = materials[0];
        } else {
            rend.sharedMaterial = materials[1];
        }
    }
}
