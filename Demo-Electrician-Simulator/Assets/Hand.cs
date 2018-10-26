using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {

    public GameObject mao;
    public GameObject eixoGancho;
    //public Quaternion rotacaoCamera;
    //public GameObject gancho;
	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.rotation = mao.transform.rotation;
        transform.position = eixoGancho.transform.position;
        //transform.localRotation = mao.transform.rotation;
        transform.Rotate(0, mao.transform.rotation.y, 0);
        //transform.SetParent(eixoGancho.transform);
    }
}
