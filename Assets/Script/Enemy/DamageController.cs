using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    protected float hp;
    public float EnemyAtkDmg;
    public virtual void EnemyOnDamage(float damage)
    {
        hp -= damage;
        //if (hp <= 0)
        //{
        //    DestroyObject();
        //}
    }
    public virtual void PlayerOnDamage(float damage)
    {
        hp -= damage;
        //if (hp <= 0)
        //{
        //    DestroyObject();
        //}
    }
    protected virtual void DestroyObject()
    {
        CommonDestroyFunction();
        Destroy(gameObject);
    }
    protected void CommonDestroyFunction()
    {
        //GameObject obj = Instantiate(destroyEffect, transform.position, Quaternion.identity);
        //if (isEnemy == true)
        //{
        //    GameManager.Instance?.RemoveEnemy(this);
        //    GameManager.TargetController?.RemoveTargetUI(this);
        //    GameManager.WeaponController?.ChangeTarget();

        //    GameManager.PlayerAircraft.OnScore(objectInfo.Score);
        //}
    }
}