using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject Coin;
    public float Area = 20f;
    public int CoinAmount = 10;

    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        //SpawnRandomEnemy();
        SpawnCoin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        Instantiate(Enemy, new Vector3(0, 1, 5), Enemy.transform.rotation);
    }

    void SpawnCoin()
    {
        for(int i = 0; i < CoinAmount; i++)
        Instantiate(Coin, CreateSpawnLocation(), Coin.transform.rotation);
    }

    Vector3 CreateSpawnLocation()
    {
        float xValue = Random.Range(-Area, Area);
        float zValue = Random.Range(-Area, Area);
        Vector3 randomPosition = new Vector3(xValue, 1f, zValue);

        return randomPosition;

    }
}
