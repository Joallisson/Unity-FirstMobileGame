using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Variável que vai controlar se o a bola vai para a esquerda ou direita
    public bool isRight;

    //Objetos invisíveis que ficam nas extremidades da barra horizontal da bola para verificar se a bola triscou neles e inverter o valor de isRight
    public Transform pointR;
    public Transform pointL;

    //Velocidade da bola
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        //Se for verdadeiro vai para a direita
        if (isRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime); //Faz o personagem ir para a direita
        }
        else{ //Se for falso vai para a esquerda
            transform.Translate(-Vector2.right * speed * Time.deltaTime); //Faz o personagem ir para a esquecer
        }

        if (Input.GetMouseButtonDown(0)) //Se pressionar o botão esquerdo do mouse ou a tela do celular com o dedo ele inverte o valor de isRight
        {
            isRight = !isRight; //Invertendo o valor de isRight
        }
        
        //Condição que verifica se a posição da bola estão entre esses dois valores
        if(transform.position.x >= 2.42f || transform.position.x <= -2.42f){
            isRight = !isRight; //Invertendo o valor de isRight
        }
    }
}
