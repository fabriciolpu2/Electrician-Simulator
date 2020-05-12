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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SensorFusivel")
        {
            fusivel.fixarFusivelNoGancho = false;         
            hinge.connectedBody = null;
            if (hinge.connectedBody == null)
            {
                //transform.SetParent(ponto_Encaixe_Trava.transform);
                ponto_Encaixe_Trava.transform.position = Posicao_Encaixe.position;
                transform.rotation.Set(0, 0, 0, 0);                
                Debug.Log("Aqui no nulo");                
                hinge.anchor = new Vector3(0,0,0);
                hinge.connectedBody = suporteFusivelBasePoste;
                rb.useGravity = true;
                fusivel.baixarGancho = true;
            }
            
        }
        if (other.tag == "GanhoPegaFusivel")
        {
            if (fusivel.pegarGanhoBase == true)
            {                
                jointEncaixaFusivel.GetComponent<HingeJoint>().connectedBody = ponto_Encaixe_Trava.GetComponent<Rigidbody>();
                jointEncaixaFusivel.GetComponent<Rigidbody>().isKinematic = false;
                jointEncaixaFusivel.GetComponent<Rigidbody>().useGravity = true;                

                JointLimits limits = hinge.limits;
                limits.min = 4f;
                limits.max = 180f;

                hinge.limits = limits;
                hinge.useLimits = true;


                pontaGanho.GetComponent<HingeJoint>().connectedBody = jointEncaixaFusivel.GetComponent<Rigidbody>();
                
                fusivel.levantarGancho = true;
                fusivel.fixarGanchoFusivel = true;
                Debug.Log("Aqui no Sensor");
                fusivel.GanchoParenteFusivel();
            }
            
        }
    }
}
