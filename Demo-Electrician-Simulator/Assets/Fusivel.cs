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
    public bool pegarGanhoBase = false;
    public bool fixarGanchoFusivel = false;
    public bool levantarGancho = false;
   


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

        //if (levantarGancho == true)
            //LevantarGancho();        
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

        mao.transform.position = new Vector3(mao.transform.position.x, mao.transform.position.y, mao.transform.position.z - 0.09f);
        Debug.Log(mao.transform.position);
        pegarGanhoBase = true;
        baixarGancho = false;
    }

    public void LevantarGancho()
    {        
        Debug.Log("Levantando Fusivel");
        mao.transform.position = new Vector3(mao.transform.position.x, mao.transform.position.y, mao.transform.position.z + 0.09f);
        levantarGancho = false;
    }
    public void FixarGanchoFusivel()
    {
        eixoGancho.transform.position = transform.position;
    }
}
