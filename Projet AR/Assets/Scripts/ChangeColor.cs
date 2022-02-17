using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color BasCorps = new Color(231, 155, 218, 0);
    public Color BasTete = new Color(124, 118, 96, 0);
    public Color Corne =new Color(196, 180, 143, 0);
    public Color Corps = new Color(119, 114, 108, 0);
    public Color Tete = new Color(231, 231, 231, 0);



    // Start is called before the first frame update
    void Start()
    {
       var MeshRenderer = this.GetComponent<Renderer>();

       MeshRenderer.materials[0].SetColor("_Color", Corps);
       MeshRenderer.materials[1].SetColor("_Color", BasCorps);
       MeshRenderer.materials[3].SetColor("_Color", BasTete);
       MeshRenderer.materials[4].SetColor("_Color", Tete);
       MeshRenderer.materials[6].SetColor("_Color", Corne);

    }

    

    // Update is called once per frame
    void Update()
    {
       var MeshRenderer = this.GetComponent<Renderer>();
       
       MeshRenderer.materials[0].SetColor("_Color", Corps);
       MeshRenderer.materials[1].SetColor("_Color", BasCorps);
       MeshRenderer.materials[3].SetColor("_Color", BasTete);
       MeshRenderer.materials[4].SetColor("_Color", Tete);
       MeshRenderer.materials[6].SetColor("_Color", Corne);
    }
}
