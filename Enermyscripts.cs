using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermyscripts : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] public float HealthEnemy;
    void Start()
    {
        //update here
    }
    void Update()
    {
        if (HealthEnemy <= 0)
        {
            Destroy(gameObject);
        }

    }
    public void EnemyHit(float _damageDone = 0)
    {
        HealthEnemy -= _damageDone;
    }
}
