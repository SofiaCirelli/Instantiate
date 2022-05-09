using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject ObjectToClone;
    public int num;
    int contador;

    public void CloneObject()
    {
        int contador = num;
        while (contador > 0)
        {
        Instantiate(ObjectToClone);
            contador--;
        }      
    }
}
