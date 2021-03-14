using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public FishControl FishScript;

    public GameObject Coin;

    public float time;

    void Start()
    {
        StartCoroutine(SpawnObjec(time));
    }


    void Update()
    {

    }

    public IEnumerator SpawnObjec(float time)
    {
        while (!FishScript.isDead)
        {
            Instantiate(Coin, new Vector3(10, Random.Range(-5, 2), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);

        }
    }


}
