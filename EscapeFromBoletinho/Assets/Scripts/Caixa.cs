using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caixa : MonoBehaviour
{

    float speed = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x <= -15){
            Destroy(gameObject);
        }

        
    }
}
