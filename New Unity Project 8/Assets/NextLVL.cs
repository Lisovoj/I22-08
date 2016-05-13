using UnityEngine;
using System.Collections;

public class NextLVL : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        ball ball = col.gameObject.GetComponent<ball>();
        if (ball != null)
        {
            Application.LoadLevel("2");
        }
    }
}
