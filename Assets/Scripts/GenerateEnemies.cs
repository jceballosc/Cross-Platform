using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject Enemy1;
   
    public int xPos;
    public int zPos;
    public int yPos;
    public int enemyCount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount <20 )
        {
            xPos = Random.Range(80, 118);
            yPos = Random.Range(210, 215);
            zPos = Random.Range(245, 366);
            Instantiate(Enemy1, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;

        }


    }
    
}
