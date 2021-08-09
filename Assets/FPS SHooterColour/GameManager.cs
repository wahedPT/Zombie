using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnDistance;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            SpawnEnemy();
        }
            }
    private void SpawnEnemy()
    {
        float randomAngle = Random.Range(0, Mathf.PI * 2.0f);


        GameObject enemyObj = Instantiate(enemyPrefab);
        enemyObj.transform.SetParent(this.transform);
        enemyObj.transform.position = new Vector3(Mathf.Cos(randomAngle), 1 + 1, Mathf.Sin(randomAngle)*spawnDistance);
    }
 public void OnEnemyDestroyed()
    {
        Debug.Log("Enemy Destroyed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
