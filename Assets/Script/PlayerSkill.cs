using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerSkill : MonoBehaviour
{
    PlayerMoving player;
    public bool isSkill;
    public float coolTime;
    public float currentTime;
    public Image SkillImage;
    public Transform pos;
    Animator animator;
    int count;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<PlayerMoving>();
        isSkill = false;
        currentTime = 0;
        count = 0;
    }
    private void Update()
    {
        transform.position = pos.position;
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }
        SkillImage.fillAmount = (currentTime / coolTime);
        if (count >= 1)
        {
            animator.SetTrigger("SkillOn");
            currentTime = coolTime;
            isSkill = false;
            count = 0;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (isSkill == true || Input.GetKey(KeyCode.Q))
        {
            if (currentTime <= 0)
            {
                if (collision.gameObject.tag == "Enemy")
                {
                    OnAttack(collision.transform);
                    count++;
                }
                if (collision.gameObject.tag == "EnemyFly")
                {
                    OnAttackFly(collision.transform);
                    count++;
                }
                if (collision.gameObject.tag == "EnemyBoss")
                {
                    OnAttackBoss(collision.transform);
                    count++;
                }
                if (collision.gameObject.tag == "EnemyBossTest")
                {
                    OnAttackBossTest(collision.transform);
                    count++;
                }
                if (collision.gameObject.tag == "EnemyRangedAttack")
                {
                    OnAttackEnemyRangedAttack(collision.transform);
                    count++;
                }
                if (collision.gameObject.tag == "EnemyBomb")
                {
                    OnAttackEnemyBomb(collision.transform);
                    count++;
                }
                //currentTime = coolTime;
            }            
            //isSkill = false;
        }
    }
    public void OnAttack(Transform Enemy)

    {
        EnemyMove enemymove = Enemy.GetComponent<EnemyMove>();
        enemymove.EnemyDamaged(PlayerMoving.SkillDamage);

    }
    public void OnAttackFly(Transform Enemy)

    {
        EnemyFlyMove enemyFlyMove = Enemy.GetComponent<EnemyFlyMove>();
        enemyFlyMove.EnemyDamaged(PlayerMoving.SkillDamage);
    }
    //?????? ????
    public void OnAttackBoss(Transform Enemy)

    {
        EnemyBossMove enemyBossMove = Enemy.GetComponent<EnemyBossMove>();
        enemyBossMove.EnemyDamaged(PlayerMoving.SkillDamage);
    }
    public void OnAttackBossTest(Transform Enemy)

    {
        EnemyBossMoveTest enemyBossMove = Enemy.GetComponent<EnemyBossMoveTest>();
        enemyBossMove.EnemyDamaged(PlayerMoving.SkillDamage);
    }
    public void OnAttackEnemyRangedAttack(Transform Enemy)

    {
        EnemyRangedAttack enemyRangedAttack = Enemy.GetComponent<EnemyRangedAttack>();
        enemyRangedAttack.EnemyDamaged(PlayerMoving.SkillDamage);
    }
    public void OnAttackEnemyBomb(Transform Enemy)

    {
        EnemyBomb enemyBomb = Enemy.GetComponent<EnemyBomb>();
        enemyBomb.EnemyDamaged(PlayerMoving.SkillDamage);
    }
    public void SkillButton()
    {
        isSkill = true;

        Invoke("SkillFalse", 0.1f);
    }
    void SkillFalse()
    {
        isSkill = false;
    }
}
