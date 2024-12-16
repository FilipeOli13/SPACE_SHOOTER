using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SofrerDanoInimigo : MonoBehaviour
{
    public float vidaInimigo = 100;
    public GameObject explosao;
    public int pontuacaoAoMorrer = 250;

    private void OnTriggerEnter2D(Collider2D colisao){
        switch(colisao.gameObject.tag){
            case "Laser":
                PoderLaser laserDano = colisao.GetComponent<PoderLaser>();
                vidaInimigo -= laserDano.valorDano;
                Destroy(laserDano.gameObject);
                if(vidaInimigo <= 0){
                    DestruirInimigo();                    
                }
            break;
            case "Player":
                CanvasGameMng.Instance.DecrementarVidaJogador();
                DestruirInimigo();
            break;
        }
    }

    private void DestruirInimigo(){
        //Ativar uma animação de explosão
        CanvasGameMng.Instance.IncrementarPontuacao(pontuacaoAoMorrer);
        GameObject go = Instantiate(explosao);
        go.transform.position = transform.position;
        Destroy(gameObject);
    }
}
