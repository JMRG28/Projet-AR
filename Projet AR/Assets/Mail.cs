using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Net;
using System.Collections.Specialized;
using System.IO;


public class Mail : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text UIMail;

    // public GameObject textDisplay;

    public void StoreMail()
    {
        string Mail = inputField.text;


        UIMail.text = "Registred mail " + Mail + " !";
        Debug.Log(UIMail.text);

       
       string url = "https://eoew1xg9m7wyqzs.m.pipedream.net";
        
        var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "POST";

        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
            string json = "{\"mail\":\""+Mail+"\",}";

            streamWriter.Write(json);
        }

        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();
            Debug.Log(result);
        } 

        



    }
}
