using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{   //Variável para atribuir os prefabs de obstáculos
    public GameObject prefab;

    //Variável que armazena o tempo dos obstáculos aparecerem
    public float spawnTime;

    //Contador para fazer os obstáculos aparecerem
    private float timeCount;

    void Update()
    {
        timeCount += Time.deltaTime; //Contador de tempo
        //Debug.Log(Time.deltaTime);

        if(timeCount >+ spawnTime){ //Se o contador de tempo for maior que o spawnTime, então cria mais obstáculos
            GameObject go = Instantiate(prefab, transform.position, transform.rotation); //Cria novos obstáculos
            Destroy(go, 5f); //Destrói obstáculos
            timeCount = 0f;
        }
    }
}
