using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkSpawn : MonoBehaviour
{

    public FishControl FishScript;

    public GameObject Shark;

    public float time;

    public float height;


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
            Instantiate(Shark, new Vector3(13, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);

        }
    }
}
