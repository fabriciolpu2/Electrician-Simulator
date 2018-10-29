using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fusivel : MonoBehaviour {

    public GameObject mao;
    public GameObject eixoGancho;
    public GameObject gancho;
    //public Quaternion rotacaoCamera;
    //public GameObject gancho;
    // Use this for initialization
    public bool fixarFusivelNoGancho = true;
    public bool baixarGancho = false;
   


    void Start () {
        //hinge = GetComponent<HingeJoint>();
        
    }
	
	// Update is called once per frame
	void Update () {
        //transform.rotation = mao.transform.rotation;        
        //transform.localRotation = mao.transform.rotation;
        //transform.Rotate(0, eixoGancho.transform.rotation.y, mao.transform.rotation.z);
        //transform.SetParent(eixoGancho.transform);
        if(fixarFusivelNoGancho == true)
        {
            FixarFusivelGancho();
        } else
        {
            DesfixarFusivelGancho();
        }
    }

    void FixarFusivelGancho()
    {
        transform.position = eixoGancho.transform.position;
    }

    void DesfixarFusivelGancho()
    {
        
        Debug.Log("Desfixando");

        if(baixarGancho == true)
        {
            PreparaGanchoPegarFusivel();
        }
        //PreparaGanchoPegarFusivel();
    }

    void PreparaGanchoPegarFusivel()
    {
        Debug.Log("recua Ganhco");
        gancho.transform.position = new Vector3(gancho.transform.position.x, gancho.transform.position.y, gancho.transform.position.z -0.25f);
        baixarGancho = false;
    }
}
