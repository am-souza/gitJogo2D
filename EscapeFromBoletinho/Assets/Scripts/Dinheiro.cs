using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinheiro : MonoBehaviour
{

    public float velocidade;

    public float forcaPulo;
    private int qtdPulos;
    const int MAX_PULOS = 1;


    // Start is called before the first frame update
    void Start()
    {
        this.qtdPulos = MAX_PULOS;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))        
        {
            Vector3 posicao = this.transform.position;
            posicao.x += velocidade;
            this. transform.position = posicao;
        }
        if (Input.GetKey(KeyCode.A))        
        {
            Vector3 posicao = this.transform.position;
            posicao.x -= velocidade;
            this. transform.position = posicao;
        }
        if (Input.GetKey(KeyCode.W) && this.qtdPulos > 0)
        {
            this.qtdPulos--;
            Vector2 forca = new Vector2(0f, this.forcaPulo);
            this.GetComponent<Rigidbody2D>().AddForce(forca, ForceMode2D.Impulse);            
        }


        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.CompareTag("chao")){
            this.qtdPulos = MAX_PULOS;
        }
    }


}
