using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject caixaPrefabRef;

    float interval = 3;
    float instantiateTime = 0;
    float intervalVariation = 1f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Time.time > instantiateTime){
            Instantiate(caixaPrefabRef, new Vector3(15.2331f, -0.75f), Quaternion.identity);
            instantiateTime = Time.time + Random.Range(interval - intervalVariation, interval + intervalVariation);
        }


        
    }
}
