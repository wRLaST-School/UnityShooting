using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletP : MonoBehaviour
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

        if(pos.sqrMagnitude > 400) Destroy(this.gameObject);

        transform.position = pos;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Enemy>().Damage(1);
            Destroy(this.gameObject);
        }
    }
}
