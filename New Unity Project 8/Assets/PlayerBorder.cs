using UnityEngine;
using System.Collections;

public class PlayerBorder : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        ball ball = col.gameObject.GetComponent<ball>();
        if (ball != null)
        {
            ball.transform.position = new Vector3(0f, 1f, 0f);
        }
    }
}
