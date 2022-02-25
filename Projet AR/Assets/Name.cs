using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.Web;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Name : MonoBehaviour
{

    public TMP_InputField inputField;
    public TMP_Text UIName;

    public TMP_InputField inputFieldMail;
    public TMP_Text UIMail;
    public void StoreName()
    {
        string name = inputField.text;
        UIName.text = "Salut " + name + " !";
        string Mail = inputFieldMail.text;
        UIMail.text = "Email enregistré : " + Mail + " !";
        Debug.Log(UIName.text);

        StartCoroutine(Upload());
    }

    IEnumerator Upload()
    {
        WWWForm form = new WWWForm();
        form.AddField("nom", inputField.text);
        form.AddField("email", inputFieldMail.text);
        string url = "https://eoew1xg9m7wyqzs.m.pipedream.net";

        using (UnityWebRequest www = UnityWebRequest.Post(url, form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
            }
        }
    }
}
