using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarLaser : MonoBehaviour
{
    //Usar o Prefab do laser
    public GameObject laser;

    //Definir um tempo de tiro
    public float tempoDeTiro;

    //Definir o tempo atual de espera para o tiro
    private float tempoDeEspera;

    //Variável para armazenar o nível do laser do jogador
    public int nivelLaser = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Verificar se a nave pode atirar
        if(Time.time > tempoDeEspera){
            Atirar();
            tempoDeEspera = Time.time + tempoDeTiro;
        }
    }

    private void Atirar(){
        GameObject ls = Instantiate(laser);
        ls.transform.position = transform.position + Vector3.up;
        if(nivelLaser == 1) return;

        InstanciarLaserDuplo(-0.195f, 0.851f);
        if(nivelLaser == 2) return;

        InstanciarLaserDuplo(-0.378f, 0.575f);
        if(nivelLaser == 3) return;

        InstanciarLaserDuplo(-0.572f, 0.323f);
        if(nivelLaser == 4) return;

        InstanciarLaserDuplo(-0.74f, -0.018f);
    }

    private void InstanciarLaserDuplo(float x, float y){
        GameObject ls1 = Instantiate(laser);
        ls1.transform.position = transform.position + new Vector3(x, y, 0);
        GameObject ls2 = Instantiate(laser);
        ls2.transform.position = transform.position + new Vector3(x*-1, y, 0);
    }

    public void AumentarNivel(){
        nivelLaser++;
        nivelLaser = nivelLaser > 5 ? 5 : nivelLaser;
    }

    public void RemoverNiveis(){
        nivelLaser = 1;
    }
}
