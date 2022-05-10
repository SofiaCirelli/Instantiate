using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject ObjectToClone;
    public int cloneAmount;
    public Text txtCloneAmount;

    public void CloneObject()
    {
        int cloneAmount = int.Parse(txtCloneAmount.text);
        int i = 0;
        while (cloneAmount > i)
        {
        Instantiate(ObjectToClone);
            cloneAmount--;
        }      
    }
}
