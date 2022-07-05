using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = transform.position;

        float speed = 0.2f;

        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0.1f;
        }

        Vector2 v2 = new Vector2(0, 0);
        v2.x += ToInt(Input.GetKey(KeyCode.RightArrow)) - ToInt(Input.GetKey(KeyCode.LeftArrow));
        v2.y += ToInt(Input.GetKey(KeyCode.UpArrow)) - ToInt(Input.GetKey(KeyCode.DownArrow));

        v2.Normalize();
        v2 *= -speed;
        transform.position = new Vector3(pos.x + v2.x, pos.y, pos.z + v2.y);
    }

    int ToInt(bool b) { return b ? 1 : 0; }
}
