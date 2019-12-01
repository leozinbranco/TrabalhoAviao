using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverTiroInimigo : MonoBehaviour
{
    public float velocidadeTiroInimigo = -1;
    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "tiroInimigo")
            //Debug.Log("Entrou na tag tiroInimigo");
            StaticGameController.moverTirosInimigos(velocidadeTiroInimigo);
    }
}
