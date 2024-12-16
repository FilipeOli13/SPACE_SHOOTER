using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMng : MonoBehaviour
{
    public static PlayerMng Instance;

    void Awake(){
        if(Instance == null){
            Instance = this;
            return;
        }
        Destroy(gameObject);
    }

    public GameObject explosao;

    public void DestruirPlayer(){
        GameObject go = Instantiate(explosao);
        go.transform.position = transform.position;
        Destroy(gameObject);
    }
}
