using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {

    public GameObject camera;
    public Quaternion rotacaoCamera;
    public GameObject gancho;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //rotacaoCamera.(camera.transform.rotation.x, camera.transform.rotation.y, camera.transform.rotation.z);
        //rotacaoCamera.Set(camera.transform.rotation.x, camera.transform.rotation.y, camera.transform.rotation.z, 1f);
        //Debug.Log(rotacaoCamera);
        //gancho.transform.rotation.SetEulerRotation(camera.transform.rotation.x + 77.566f, camera.transform.rotation.y, camera.transform.rotation.z);
        //gancho.transform.rotation.SetLookRotation(camera.transform.rotation.x + 77.566f, camera.transform.rotation.y, camera.transform.rotation.z, camera.transform.forward);
            //(camera.transform.rotation.x + 77.566f, camera.transform.rotation.y, camera.transform.rotation.z);

        //gancho.transform.SetPositionAndRotation(camera.)
    }
}
