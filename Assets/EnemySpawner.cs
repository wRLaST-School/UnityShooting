using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    double timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 1){timer = 0; EverySecondEvent();}
    }

    private void EverySecondEvent()
    {Debug.Log("unti");
        Instantiate(enemy, new Vector3(gameObject.transform.position.x + Random.Range(-5.0f, 5.0f), gameObject.transform.position.y, gameObject.transform.position.z - Random.Range(-5.0f, 5.0f)), Quaternion.identity);
    }
}
