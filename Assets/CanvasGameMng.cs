using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasGameMng : MonoBehaviour
{
    public static CanvasGameMng Instance;

    void Awake(){
        if(Instance == null){
            Instance = this;
            return;
        }
        Destroy(gameObject);
    }

    public GameObject[] imgsVidasPlayer;
    public TextMeshProUGUI txtPontuacao;
    public TextMeshProUGUI txtNivelJogo;

    private int vidaJogador;
    private int nivelJogo;
    private int pontuacaoJogo;

    // Start is called before the first frame update
    void Start()
    {
        vidaJogador = imgsVidasPlayer.Length-1;
        nivelJogo = 1;
        pontuacaoJogo = 0;
        txtPontuacao.text = $"{pontuacaoJogo}";
        txtNivelJogo.text = $"Nv. {nivelJogo}";
    }

    public void IncrementarPontuacao(int pontuacao){
        pontuacaoJogo += pontuacao;
        txtPontuacao.text = $"{pontuacaoJogo}";
    }

    public void DecrementarVidaJogador(){
        if(vidaJogador <= 0){
            Debug.Log("Game Over");
            PlayerMng.Instance.DestruirPlayer();
        }else{
            imgsVidasPlayer[vidaJogador].SetActive(false);
            vidaJogador--;
        }
    }
}
