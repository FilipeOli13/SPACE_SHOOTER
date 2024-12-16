using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpLaser : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D colisao){
        if(colisao.gameObject.tag.Equals("Player")){
            //Aumentar o nível do laser do jogador
            colisao.gameObject.GetComponent<AtirarLaser>().AumentarNivel();
            //Destruir o gameObject
            Destroy(gameObject);
        }
    }
}
