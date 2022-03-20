using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //Criando variável do tipo Rigidbody2D do obstaculo
    public Rigidbody2D rig;

    //Variável para atribuir velocidade ao obstáculo
    public float speed;

    void Start()
    {
        transform.Rotate(new Vector3(0, 0, Random.Range(-120, -70))); //Fazer o obstáculo girar //O 1º parametro é o valor de x, o 2º é o de y, o 3º é o de z //A função Random.Range() gera números aleatórios entre dois valores
    }

    void FixedUpdate() //O FixedUpdate() é o mais ideal para trbalhar com física
    {
        //Movendo o personagem para a baixo
        rig.MovePosition(transform.position + transform.right * speed * Time.deltaTime); //transform.right => O bjeto sempre vai se mover para a sua direita //Vector3.right => O objeto sempre vai se mover para a direita da tela
    }

    private void OnTriggerEnter2D(Collider2D collision) { //Quando o obstacle triscar na bola

        if(collision.CompareTag("Player")){ //Se o obstacle/obstáculo tocar no player/bola, Game Over
            GameController.instance.ShowGameOver(); //Mostra o game over na tela
        }
    }
}
