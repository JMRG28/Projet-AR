using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Net;
using System.Collections.Specialized;
using System.IO;


public class Name : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text UIName;

    // public GameObject textDisplay;

    public void StoreName()
    {
        string name = inputField.text;


        UIName.text = "Salut " + name + " !";
        Debug.Log(UIName.text);

       
        string url = "https://eoew1xg9m7wyqzs.m.pipedream.net";
        
        var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "POST";

        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
            string json = "{\"user\":\""+name+"\",}";

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
