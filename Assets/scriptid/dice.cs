using UnityEngine;
using System.Collections;

public class dice : MonoBehaviour {

    public moveonpath liikuma;
    

    

    public string buttonName = "Fire1";
    public float forceAmount = 10.0f;
    public float torqueAmount = 10.0f;
    public ForceMode forceMode;

    public int side ;
    private int timer;
    int CalcSideUp()
    {
        
        float dotFwd = Vector3.Dot(transform.forward, Vector3.up);
        if (dotFwd > 0.99f) return 2;
        if (dotFwd < -0.99f) return 5;
        float dotRight = Vector3.Dot(transform.right, Vector3.up);      //kuubiku tulemus
        if (dotRight > 0.99f) return 4;
        if (dotRight < -0.99f) return 3;
        float dotUp = Vector3.Dot(transform.up, Vector3.up);
        if (dotUp > 0.99f) return 1;
        if (dotUp < -0.99f) return 6;
        return 0;
  
    }

    // Update is called once per frame

    void Update() {
    
       
    
    if (Input.GetButtonDown(buttonName)) //täringu viskamine
        {
            
            GetComponent<Rigidbody>().AddForce(Random.onUnitSphere*forceAmount, forceMode);
            GetComponent<Rigidbody>().AddTorque(Random.onUnitSphere * torqueAmount, forceMode);
            timer = 480;
            
            
        }
    if (timer > -1) { 
        timer--;
        }
        
        if (transform.GetComponent<Rigidbody>().IsSleeping() && timer == 0)
        {
            liikuma.Start();
        }
        if (side > 0) Debug.Log("Side = " + side);
        side = CalcSideUp();
    

    }

}