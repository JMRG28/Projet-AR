using HSVPicker;
using UnityEngine;
using System.Collections;

[System.Serializable]
public class array2d
{
    public Renderer[] renderers;
    public int [] materialNumbers;
}
namespace HSVPickerExamples
{
    public class ColorPickerTester : MonoBehaviour 
    {
        public array2d[] paintSections;

        private Renderer[] currentRenderers;
        private int[] currentMatNums;

        public ColorPicker picker;

        public Color Color = Color.red;
        public bool SetColorOnStart = false;

	    // Use this for initialization
	    void Start () 
        {   

         
            setPaintSection (0);
            picker.CurrentColor = currentRenderers[0].material.color;

            picker.onValueChanged.AddListener(color =>
            {   
                for (int i = 0; i < currentRenderers.Length; i++) {
                int matN = currentMatNums[i];
                currentRenderers[i].materials[matN].color = picker.CurrentColor;
                }
                
            });

            if(SetColorOnStart) 
            {
                picker.CurrentColor = Color;
            }
        }
	
	    // Update is called once per frame
	    void Update () {
	
	    }


        public void setPaintSection (int _num){
            currentRenderers = paintSections[_num].renderers;
            currentMatNums = paintSections[_num].materialNumbers;

        }
    }
}