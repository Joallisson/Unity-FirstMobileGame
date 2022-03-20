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

        //Função que verifica a distância entre a bola e os objetos invisíveis nos extremos //Dentro do if está usnado a lógica que OU inverte a direção da bola para um lado ou pro outro
        if (Vector2.Distance(transform.position, pointL.position) < 0.1f || Vector2.Distance(pointR.position, transform.position) < 0.5f) //Verificar se a bola triscou no objeto invisível que está na extremidade da esquerda // transform.position => Retorna a posição da bola e pointL.position => Retorna a posição do objeto na extermidade da esquerda, ái é feita a subtração dessas duas posições
        {
            isRight = !isRight; //Invertendo o valor de isRight
        }
    }
}
