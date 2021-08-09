using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<BulletController>()!=null)
        {
            Destroy(gameObject);
        }
    }

    public void OnEnemyDestroyed()
    {
        Debug.Log("Enemy Destroyed");
    }
}
