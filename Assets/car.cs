using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class car : MonoBehaviour
{
    float velocidad = 0.5f;
    public KeyCode teclaAsignada = KeyCode.F1;
       public string nombre;
    public Text marcador;
    int cuenta = 0;
    void Update()
    {

        if (cuenta > 114)
        {
            Debug.Log("el ganador es" + nombre);

        }
        else
        {
            if (Input.GetKeyDown(teclaAsignada))
            {
                this.transform.Translate(new Vector3(velocidad, 0, 0));
                cuenta++;
                marcador.text = "" + cuenta;


            }
        }
        
    }
}
    
