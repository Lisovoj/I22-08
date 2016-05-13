using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
    public Vector3 InitialInpulse;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(InitialInpulse, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
