using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusivelMecanica : MonoBehaviour {

    public Fusivel fusivel;
    public HingeJoint hinge;
    public Rigidbody suporteFusivelBasePoste;
    public Rigidbody rb;
    // Use this for initialization
    void Start () {        
        // Disable the spring on the HingeJoint component.
        hinge = GetComponent<HingeJoint>();
        rb = GetComponent<Rigidbody>();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SensorFusivel")
        {
            fusivel.fixarFusivelNoGancho = false;
            Debug.Log("Chegou aqui no sensor");
            //hinge.useSpring = false;
            hinge.connectedBody = null;
            if (hinge.connectedBody == null)
            {
                Debug.Log("Aqui no nulo");                
                hinge.anchor = new Vector3(-0.09f, -0.22f, 0);
                hinge.connectedBody = suporteFusivelBasePoste;
                rb.useGravity = true;
            }
            
        }
    }
}
