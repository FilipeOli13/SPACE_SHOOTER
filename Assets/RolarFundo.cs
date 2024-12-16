using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RolarFundo : MonoBehaviour
{
    private Material material;
    private float offset = 0;
    public float velocidadeDeMovimento;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += velocidadeDeMovimento * Time.deltaTime;
        material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
