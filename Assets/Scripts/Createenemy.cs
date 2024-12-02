using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Createenemy : MonoBehaviour
{
    public GameManagerContol gamemanager;
    public GameObject enemyPrefab;
    public float xMinPosition;
    public float xMaxPosition;
    public float yposition;
    float TimeToCreateEnemy = 5;
    float CurrentTimeToCreateEnemy;
    void Update()
    {
        CurrentTimeToCreateEnemy = CurrentTimeToCreateEnemy + Time.deltaTime;
        if(CurrentTimeToCreateEnemy >= TimeToCreateEnemy)
        {
            CreateEnemy();
            CurrentTimeToCreateEnemy = 0;
        }
    }
    void CreateEnemy()
    {
        float xPosition = Random.Range(xMinPosition, xMaxPosition);
        Vector2 positionToCreate = new Vector2(xPosition, yposition);
        GameObject enemy = Instantiate(enemyPrefab, positionToCreate, transform.rotation);
    }
    
}
