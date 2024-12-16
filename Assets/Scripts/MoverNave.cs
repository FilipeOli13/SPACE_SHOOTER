using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverNave : MonoBehaviour
{
    public float velocidade = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movimentar o jogador para a posição do mouse com os limites de x e y
        Vector2 posicaoDoMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicaoDoMouse = new Vector2(Mathf.Clamp(posicaoDoMouse.x, -3.5f, 3.5f), Mathf.Clamp(posicaoDoMouse.y, -6.5f, 6.5f));
        float velocidadeMovimentacao = velocidade * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, posicaoDoMouse, velocidadeMovimentacao);
    }
}
