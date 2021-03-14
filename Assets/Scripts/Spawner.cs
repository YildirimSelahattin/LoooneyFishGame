using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public FishControl FishScript;

    public GameObject Rod;

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
        while(!FishScript.isDead)
        {
            Instantiate(Rod, new Vector3(10, Random.Range(2,8), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);

        }
    }


}
