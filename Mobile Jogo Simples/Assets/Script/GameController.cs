using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Importando biblioteca para reiniciar o jogo
using UnityEngine.UI; //Biblioteca que lida com a interface do usuário para fazer a contagem de itens coletados

public class GameController : MonoBehaviour
{   
    private int score; //Variável qua vai armazenar a contagem dos pontos

    public Text scoreText; //variavel d texto que mostra a Contagem dos itens coletáveis

    public GameObject gameOver; //Será a tela do game over

    public static GameController instance; //Variável que irá atribuir o objeto a ser instanciado

    private void Awake() { //Essa função é chamada assim que o script é inicializado
        instance = this; //É como se dentro da variável instance tivesse toda a minha classe
        Time.timeScale = 1; //Reinicar o jogo depois que clicar no botão reiniciar
    }

    public void ShowGameOver(){ //Irá mostrar o game over
        gameOver.SetActive(true); //Mostra o game over na tela
        Time.timeScale = 0; //Parar o jogo depois que aparecer a tela do game over
    }

    public void RestartGame(){
        Scene scene = SceneManager.GetActiveScene(); //Atribuindo à variável scene a cena/fase atual
        SceneManager.LoadScene(scene.name); //Carregar/Reiniciar a cena atual
    }

    public void AddScore(){
        score++;
        scoreText.text = score.ToString(); //Mudando o score sempre que o usuário coletar os coletáveis e antes de passar é convertido o score do tipo int para uma string
    }
}
