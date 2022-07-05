using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int HP;
    private double timer;
    public GameObject Bullet;
    public GameObject player;

    Vector3 moveVec;

    // Start is called before the first frame update
    void Start()
    {
        HP = 10;
        timer = 0;
        player = GameObject.FindGameObjectWithTag("Player");

        moveVec = new Vector3 (
            Random.Range(-1000.0f, 1000.0f),
            0,
            Random.Range(-1000.0f, 1000.0f)
        ).normalized;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position = gameObject.transform.position + (moveVec * 0.05f);

        if(HP <= 0)
        {
            Destroy(this.gameObject);
        }
        
        timer += Time.deltaTime;
        if(timer >= 1){timer = 0; EverySecondEvent();}

        if(gameObject.transform.position.sqrMagnitude > 800) Destroy(this.gameObject);
    }
    public void Damage(int damage = 1)
    {
        HP -= damage;
    }

    private void EverySecondEvent()
    {
        Vector3 f = (player.gameObject.transform.position - this.gameObject.transform.position);
        f.y = 0;
        Shot(this.gameObject.transform.position, f.normalized, 0.3f);
    }

    private void Shot( Vector3 pos, Vector3 front, float speed)
    {
        Debug.Log("hoge");
        GameObject b = Instantiate(Bullet, pos, Quaternion.identity) as GameObject;
        b.GetComponent<bulletE>().frontVec = front;
        b.GetComponent<bulletE>().speed = speed;
    }

}
