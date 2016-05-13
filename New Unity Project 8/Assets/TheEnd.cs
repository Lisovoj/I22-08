using UnityEngine;
using System.Collections;

public class TheEnd : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        ball ball = col.gameObject.GetComponent<ball>();
        if (ball != null)
        {
            Application.LoadLevel("4");
        }
    }
	
	
}
