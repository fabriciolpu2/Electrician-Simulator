using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusivelMecanica : MonoBehaviour {

    public Fusivel fusivel;
    public HingeJoint hinge;
    public Rigidbody suporteFusivelBasePoste;
    public Rigidbody rb;
    public GameObject ponto_Encaixe_Trava;
    public Transform Posicao_Encaixe;
    public GameObject sensorBaseFusivel;
    public GameObject jointEncaixaFusivel;
    public GameObject pontaGanho;


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
            //Debug.Log("Chegou aqui no sensor");
            //hinge.useSpring = false;
            hinge.connectedBody = null;
            if (hinge.connectedBody == null)
            {
                //transform.SetParent(ponto_Encaixe_Trava.transform);
                ponto_Encaixe_Trava.transform.position = Posicao_Encaixe.position;
                transform.rotation.Set(0, 0, 0, 0);
                //transform.SetPositionAndRotation(new Vector3(Posicao_Encaixe.position.x, Posicao_Encaixe.position.y, Posicao_Encaixe.position.z),new Quaternion(0,,90,0) );
                //fusivel.gameObject.transform.SetParent
                Debug.Log("Aqui no nulo");                
                hinge.anchor = new Vector3(0,0,0);
                hinge.connectedBody = suporteFusivelBasePoste;
                rb.useGravity = true;
                fusivel.baixarGancho = true;
            }
            
        }

        //Debug.Log(other.name);
        if (other.tag == "GanhoPegaFusivel")
        {
            if (fusivel.pegarGanhoBase == true)
            {
                //SuperPivot.API.Space.Local;
                //SuperPivot.API.SetPivot(transform, new Vector3(3,3,3),SuperPivot.API.Space.Local);
                jointEncaixaFusivel.GetComponent<HingeJoint>().connectedBody = ponto_Encaixe_Trava.GetComponent<Rigidbody>();
                jointEncaixaFusivel.GetComponent<Rigidbody>().isKinematic = false;
                jointEncaixaFusivel.GetComponent<Rigidbody>().useGravity = true;                

                JointLimits limits = hinge.limits;
                limits.min = 4f;
                limits.max = 180f;

                hinge.limits = limits;
                hinge.useLimits = true;


                pontaGanho.GetComponent<HingeJoint>().connectedBody = jointEncaixaFusivel.GetComponent<Rigidbody>();

                //JointLimits.Equals
                //fusivel.LevantarFusivel();
                fusivel.levantarGancho = true;
                fusivel.fixarGanchoFusivel = true;
                Debug.Log("Aqui no Sensor");
            }
            
        }
    }
}
