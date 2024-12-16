using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarObjeto : MonoBehaviour
{
    public GameObject objeto;
    public float tempoDeSurgimento;
    private float tempoDeEspera;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > tempoDeEspera){
            GameObject objetoInstanciado = Instantiate(objeto);
            float posicaoX = Random.Range(-3.5f, 3.5f);
            objetoInstanciado.transform.position = new Vector3(posicaoX, 8.5f, 0);
            tempoDeEspera = Time.time + tempoDeSurgimento;
        }
    }
}
