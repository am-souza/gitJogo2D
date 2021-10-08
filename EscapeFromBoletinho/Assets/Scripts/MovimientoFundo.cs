using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFundo : MonoBehaviour
{

    public SpriteRenderer[] grounds;

    Vector2 endPosition = new Vector2(-20.75f, -3.508f);
    Vector2 startPosition = new Vector2(15.2331f, -3.508f);

    float speed = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < grounds.Length; i++){
            grounds[i].transform.position += Vector3.left * speed * Time.deltaTime;
            if (grounds[i].transform.position.x <= endPosition.x){
                grounds[i].transform.position = startPosition;
            }
        }


        
    }
}
