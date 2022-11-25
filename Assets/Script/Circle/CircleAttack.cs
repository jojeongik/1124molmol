using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CircleAttack : MonoBehaviour
{
    Rigidbody2D rigid;
    public GameManger gameManger;
    float EnemyDamage;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<DamageController>()?.EnemyOnDamage(PlayerMoving.TotalPlayerDamage);
        }

    }


}
