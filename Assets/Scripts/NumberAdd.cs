using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberAdd : MonoBehaviour
{
    public Text numberAdd;
    int counter;

    public void Add()
    {
        counter++;
        numberAdd.text = counter + " ";
    }

    public void Less()
    {
        counter--;
        numberAdd.text = counter + " ";
    }
    
}
