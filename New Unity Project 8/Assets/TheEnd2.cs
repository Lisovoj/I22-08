using UnityEngine;
using System.Collections;

public class TheEnd2 : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        ball ball = col.gameObject.GetComponent<ball>();
        if (ball != null)
        {
            Application.LoadLevel("4");
        }
    }
}
