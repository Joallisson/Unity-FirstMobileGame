using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colectable : MonoBehaviour
{
    public Rigidbody2D rig; //Variável que armazena o collectable
    public float speed; //Velocidade do collectable

    void FixedUpdate() //Essa funhjção é nativa da unity e é melhor pra lidar com física de objetos
    {
        rig.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime); //Movendo o collectable
    }

    private void OnTriggerEnter2D(Collider2D collision){ //Função para detectar colisões entre objetos 2D

        if(collision.CompareTag("Player")){ //Se o coletável tocar no player
            GameController.instance.AddScore(); //Chamando função para adicionar pontos no score da classe GameController
            Destroy(gameObject); //Destruindo coletável assim que ele é coletado
        }
    }


}
