using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public string name;
    public InputField inputField;
    public GameObject textDisplay;

    public void StoreName() 
     {  
         Debug.Log(inputField..GetComponent<Text>().text);
         name = inputField..GetComponent<Text>().text;

        // textDisplay.text = "Salut " + name;


    }
}
