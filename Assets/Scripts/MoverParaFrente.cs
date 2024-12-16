using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverParaFrente : MonoBehaviour
{
    public float velocidade;

    //Tempo de existência do objeto
    public float tempoDeExistencia;

    // Start is called before the first frame update
    void Start()
    {
        //Destruir o objeto após um tempo
        Destroy(gameObject, tempoDeExistencia);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * velocidade * Time.deltaTime);
    }
}
