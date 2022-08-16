using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1 : MonoBehaviour
{

    [SerializeField] int[] arrayDePuntajes = new int[10];
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El mayor puntaje es" + ObtenerMayorPuntaje());
        Debug.Log("el indice de menor puntaje es " + ObtenerNivelDeMenorPuntaje());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int ObtenerMayorPuntaje()
    {
        int nroMayor = 0;

        foreach(int num in arrayDePuntajes)
        {
            if (num > nroMayor)
            {
                nroMayor = num;
            }
        }
        return nroMayor;
    }

   int ObtenerNivelDeMenorPuntaje()
    {
        int indiceNivel = 0;
        int menorpuntaje = arrayDePuntajes[0];
        for(int i= 1; i <arrayDePuntajes.Length; i++)
        {
            if (arrayDePuntajes[i] < menorpuntaje)
            {
                indiceNivel = i;
                menorpuntaje = arrayDePuntajes[i];
            }
        }
        return indiceNivel;
    }

    float ObtenerPuntajePromedio()
    {
        float promedio;
        float suma = 0;
        for (int i = 0; i < arrayDePuntajes.Length; i++)
        {

            suma += arrayDePuntajes[i];
            
        }
        promedio = suma / arrayDePuntajes.Length;
        return promedio;
    }

}
