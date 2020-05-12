using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fusivel : MonoBehaviour {

    public GameObject mao;
    public GameObject eixoGancho;
    public GameObject gancho;   
    public bool fixarFusivelNoGancho = true;
    public bool baixarGancho = false;
    public bool pegarGanhoBase = false;
    public bool fixarGanchoFusivel = false;
    public bool levantarGancho = false;
       
	
	// Update is called once per frame
	void Update () {        
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
        if(baixarGancho == true)
        {
            PreparaGanchoPegarFusivel();
        }
    }

    void PreparaGanchoPegarFusivel()
    {
        mao.transform.position = new Vector3(mao.transform.position.x, mao.transform.position.y, mao.transform.position.z - 0.09f);        
        pegarGanhoBase = true;
        baixarGancho = false;
    }

    public void LevantarGancho()
    {                
        mao.transform.position = new Vector3(mao.transform.position.x, mao.transform.position.y, mao.transform.position.z + 0.09f);
        levantarGancho = false;
    }
    public void FixarGanchoFusivel()
    {
        eixoGancho.transform.position = transform.position;
    }

    public void GanchoParenteFusivel()
    {
        gancho.transform.SetParent(this.transform);
    }
}
