using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tresgustos : MonoBehaviour
{
    public string saborHelado;
    public int cantidadGramos;
    float costoGramo = 1.25f;
    float descuento = 0.9f;
    float precioFinal;

    // Start is called before the first frame update
    void Start()
    {
        if (cantidadGramos < 250 || cantidadGramos > 3000)
        {
            Debug.Log("ERROR, CANTIDAD MAYOR O MENOR A LA ESPERADA");
            return;
        }
        if (saborHelado != "CHO"  && saborHelado != "FRU" && saborHelado != "DDL")
        {
            Debug.Log("SABOR NO DISPONIBLE");
            return;
        }

        if (saborHelado == "CHO" || saborHelado == "DDL")
        {
            precioFinal = costoGramo * cantidadGramos;
        } else if (saborHelado == "FRU")
        {
            precioFinal = costoGramo * (cantidadGramos * descuento);
        }
        Debug.Log("PRECIO TOTAL:" + precioFinal);
    }
// Update is called once per frame
void Update()
    {
        
    }
}

