using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ClickControl : MonoBehaviour
{
  
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Gm.CurrentWord += GetComponent<TextMeshPro>().text;
        Gm.LetterNum += 1;
        Gm.SelectLetter[Gm.LetterNum]= GetComponent<TextMeshPro>().text;
        Debug.Log(Gm.CurrentWord);
    }
}


