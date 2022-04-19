using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Examen : MonoBehaviour
{
    public string ingresasabor = "";
    public float canthelado;
    // Start is called before the first frame update
    void Start()
    {
        
        float descuento;
        float resultado;
        if (canthelado < 250 || canthelado > 3000)
        {
            Debug.Log("No se pueden esos valores");
        }
        else
        {
            switch (ingresasabor)
            {
                case "CHO":
                resultado = (canthelado / 1000) * 500;
                Debug.Log("Sale $" + resultado);
                break;
                case "FRU":
                resultado = (canthelado / 1000) * 500;
                descuento = resultado * 0.9f;
                Debug.Log("Sale $" + descuento);
                break;
                case "DLL":
                resultado = (canthelado / 1000) * 500;
                Debug.Log("Sale $" + resultado);
               break;
                default:
                    Debug.Log("ingreso otro gusto no disponible");
                    break;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
