using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    public GameObject Bullet;
    public float ShotSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Shot(gameObject.transform.position, new Vector3(-1, 0, 0), ShotSpeed);
            Shot(gameObject.transform.position, new Vector3(-1, 0, 0.2f), ShotSpeed);
            Shot(gameObject.transform.position, new Vector3(-1, 0, -0.2f), ShotSpeed);
        }

        if(Input.GetKey(KeyCode.B))
        {
            foreach(GameObject g in GameObject.FindGameObjectsWithTag("bulletE"))
            {
                Destroy(g);
            }
        }
    }

    void Shot( Vector3 pos, Vector3 front, float speed)
    {
        GameObject b = Instantiate(Bullet, pos, Quaternion.identity) as GameObject;
        b.GetComponent<BulletP>().frontVec = front;
        b.GetComponent<BulletP>().speed = speed;
    }
}
