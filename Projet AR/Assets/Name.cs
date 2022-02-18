using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Name : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text UIName;
    // public GameObject textDisplay;

    public void StoreName() 
     {  string name = inputField.text;
         

         UIName.text = "Salut " + name + " !";
         Debug.Log(UIName.text);

        // textDisplay.text = "Salut " + name;


    }
}
