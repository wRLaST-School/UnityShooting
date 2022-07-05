using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletE : MonoBehaviour
{
    public Vector3 frontVec;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = transform.position;

        pos += frontVec * speed;

        if(pos.sqrMagnitude > 800) Destroy(this.gameObject);

        transform.position = pos;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(other);
            Destroy(this.gameObject);
        }
    }
}
