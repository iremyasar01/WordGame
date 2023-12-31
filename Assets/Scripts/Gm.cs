using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Gm : MonoBehaviour
{
 
    public int CorrectWord = 0;
    public int TotalWord = 8;
    public static Gm Instance;
    public GameObject NextText;
    public TextMeshPro SpelledWordTmPro;
    public static string CurrentWord;
    public Transform SpelledWord;
    public KeyCode RMB; //rightmost button
    public Transform LetterH;
    public Transform LetterE;
    public Transform LetterA;
    public Transform LetterR;
    public Transform LetterT;
    public Transform LetterL;

    //HEAT
    public Transform LetterH2;
    public Transform LetterE2;
    public Transform LetterA2;
    public Transform LetterT2;

    //HATE
    public Transform LetterH3;
    public Transform LetterA3;
    public Transform LetterT3;
    public Transform LetterE3;

    //HEAR
    public Transform LetterH4;
    public Transform LetterE4;
    public Transform LetterA4;
    public Transform LetterR4;

    //HEAL
    public Transform LetterH5;
    public Transform LetterE5;
    public Transform LetterA5;
    public Transform LetterL5;
    //LATE
    public Transform LetterL6;
    public Transform LetterA6;
    public Transform LetterT6;
    public Transform LetterE6;

    //RATE
    public Transform LetterR7;
    public Transform LetterA7;
    public Transform LetterT7;
    public Transform LetterE7;

    //TALE
    public Transform LetterT8;
    public Transform LetterA8;
    public Transform LetterL8;
    public Transform LetterE8;

    public Transform BottomL1Obj;//Bottom Letter object
    public Transform BottomL2Obj;
    public Transform BottomL3Obj;
    public Transform BottomL4Obj;
    public Transform BottomL5Obj;
    public Transform BottomL6Obj;

    public Transform Bottom21Obj;
    public Transform Bottom22Obj;
    public Transform Bottom23Obj;
    public Transform Bottom24Obj;

    public Transform BottomL31Obj;
    public Transform BottomL32Obj;
    public Transform BottomL33Obj;
    public Transform BottomL34Obj;

    public Transform BottomL41Obj;
    public Transform BottomL42Obj;
    public Transform BottomL43Obj;
    public Transform BottomL44Obj;

    public Transform BottomL51Obj;
    public Transform BottomL52Obj;
    public Transform BottomL53Obj;
    public Transform BottomL54Obj;

    public Transform BottomL61Obj;
    public Transform BottomL62Obj;
    public Transform BottomL63Obj;
    public Transform BottomL64Obj;

    public Transform BottomL71Obj;
    public Transform BottomL72Obj;
    public Transform BottomL73Obj;
    public Transform BottomL74Obj;

    public Transform BottomL81Obj;
    public Transform BottomL82Obj;
    public Transform BottomL83Obj;
    public Transform BottomL84Obj;





    //Avaible Letter
    public List<string> AvailLetter1 = new List<string>() { "L" };
    public List<string> AvailLetter2 = new List<string>() { "E" };
    public List<string> AvailLetter3 = new List<string>() { "H" };
    public List<string> AvailLetter4 = new List<string>() { "T" };
    public List<string> AvailLetter5 = new List<string>() { "A" };
    public List<string> AvailLetter6 = new List<string>() { "R" };

    public int WordLen;
    public string word5l = "HEART";
    public string wordl4l = "HEAT";
    public string word4l2 = "HATE";
    public string word4l3 = "HEAR";
    public string word4l4 = "HEAL";
    public string word4l5 = "LATE";
    public string word4L6 = "RATE";
    public string word4l7 = "TALE";


    public static List<string> SelectLetter = new List<string>() { " ", " ", " ", " ", " ", " " };
    public static int LetterNum = 0;

    public static List<string> CorrectWordsList = new List<string>();
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }


    void Start()
    {
        NextText.SetActive(false);
     

        SpelledWordTmPro = SpelledWord.GetComponent<TextMeshPro>();
        BottomL1Obj.GetComponent<TextMeshPro>().text = AvailLetter1[0];
        BottomL2Obj.GetComponent<TextMeshPro>().text = AvailLetter2[0];
        BottomL3Obj.GetComponent<TextMeshPro>().text = AvailLetter3[0];
        BottomL4Obj.GetComponent<TextMeshPro>().text = AvailLetter4[0];
        BottomL5Obj.GetComponent<TextMeshPro>().text = AvailLetter5[0];
        BottomL6Obj.GetComponent<TextMeshPro>().text = AvailLetter6[0];


    }



    void Update()
    {
        SpelledWordTmPro.text = CurrentWord;

        if (Input.GetKeyDown(RMB))
        {
            WordLen = CurrentWord.Length;
            Debug.Log(WordLen);
        }


        if (WordLen == 4)
        {
            if (CurrentWord == wordl4l)
            {
                Debug.Log("Correct 4 letter");


                LetterH2.GetComponent<TextMeshPro>().text = SelectLetter[1];
                LetterE2.GetComponent<TextMeshPro>().text = SelectLetter[2];
                LetterA2.GetComponent<TextMeshPro>().text = SelectLetter[3];
                LetterT2.GetComponent<TextMeshPro>().text = SelectLetter[4];
         
                CurrentWord = "";
                LetterNum = 0;
                NumPlus();

            }
            else if (CurrentWord == word4l2)
            {
                Debug.Log("Correct 4 letter");


                LetterH3.GetComponent<TextMeshPro>().text = SelectLetter[1];
                LetterA3.GetComponent<TextMeshPro>().text = SelectLetter[2];
                LetterT3.GetComponent<TextMeshPro>().text = SelectLetter[3];
                LetterE3.GetComponent<TextMeshPro>().text = SelectLetter[4];
               
                CurrentWord = "";
                LetterNum = 0;
                NumPlus();
            }
            else if (CurrentWord == word4l3)
            {
                Debug.Log("Correct 4 letter");



                LetterH4.GetComponent<TextMeshPro>().text = SelectLetter[1];
                LetterE4.GetComponent<TextMeshPro>().text = SelectLetter[2];
                LetterA4.GetComponent<TextMeshPro>().text = SelectLetter[3];
                LetterR4.GetComponent<TextMeshPro>().text = SelectLetter[4];
 
                CurrentWord = "";
                LetterNum = 0;
                NumPlus();

            }
            else if (CurrentWord == word4l4)
            {
                Debug.Log("Correct 4 letter");


                LetterH5.GetComponent<TextMeshPro>().text = SelectLetter[1];
                LetterE5.GetComponent<TextMeshPro>().text = SelectLetter[2];
                LetterA5.GetComponent<TextMeshPro>().text = SelectLetter[3];
                LetterL5.GetComponent<TextMeshPro>().text = SelectLetter[4];
               
                CurrentWord = "";
                LetterNum = 0;
                NumPlus();

            }
            else if (CurrentWord == word4l5)
            {
                Debug.Log("Correct 4 letter");

                LetterL6.GetComponent<TextMeshPro>().text = SelectLetter[1];
                LetterA6.GetComponent<TextMeshPro>().text = SelectLetter[2];
                LetterT6.GetComponent<TextMeshPro>().text = SelectLetter[3];
                LetterE6.GetComponent<TextMeshPro>().text = SelectLetter[4];
            
                CurrentWord = "";
                LetterNum = 0;
                NumPlus();
            }
            else if (CurrentWord == word4L6)
            {
                Debug.Log("Correct 4 letter");

                LetterR7.GetComponent<TextMeshPro>().text = SelectLetter[1];
                LetterA7.GetComponent<TextMeshPro>().text = SelectLetter[2];
                LetterT7.GetComponent<TextMeshPro>().text = SelectLetter[3];
                LetterE7.GetComponent<TextMeshPro>().text = SelectLetter[4];
              
                CurrentWord = "";
                LetterNum = 0;
                NumPlus();

            }
            else if (CurrentWord == word4l7)
            {
                Debug.Log("Correct 4 letter");

                LetterT8.GetComponent<TextMeshPro>().text = SelectLetter[1];
                LetterA8.GetComponent<TextMeshPro>().text = SelectLetter[2];
                LetterL8.GetComponent<TextMeshPro>().text = SelectLetter[3];
                LetterE8.GetComponent<TextMeshPro>().text = SelectLetter[4];
               
                CurrentWord = "";
                LetterNum = 0;
                NumPlus();

            }

            else
            {
                Debug.Log("Wrong 4 letter");


            }

        }
        if (WordLen == 5)
        {
            if (CurrentWord == word5l)
            {
                Debug.Log("Correct 5 letter");


                LetterH.GetComponent<TextMeshPro>().text = SelectLetter[1];
                LetterE.GetComponent<TextMeshPro>().text = SelectLetter[2];
                LetterA.GetComponent<TextMeshPro>().text = SelectLetter[3];
                LetterR.GetComponent<TextMeshPro>().text = SelectLetter[4];
                LetterT.GetComponent<TextMeshPro>().text = SelectLetter[5];
           
                CurrentWord = "";
                LetterNum = 0;
                NumPlus();
            }
            else
            {
                Debug.Log("Wrong 5 letter");


            }

        }

    }
    public void NumPlus()
    {
        if (!CorrectWordsList.Contains(CurrentWord))
        {
            CorrectWord++;
        }
        if (CorrectWord == TotalWord)
        {
            NextText.SetActive(true);
            Debug.Log("kazandınız");
        }

    }
    /*
    public void AddCorrectWord(string Word)
    {
        if (!CorrectWordsList.Contains(Word))
        {
            CorrectWordsList.Add(Word);
            Debug.Log("Doğru kelime sayısı: " + CorrectWordsList.Count);
        }
    }


    
public void CheckWord(string word)
{
   if (!CorrectWords.Contains(word))
   {
       CorrectWords.Add(word);
       Debug.Log("Doğru kelime sayısı: " + CorrectWords.Count);
   }
}

public void CheckAndAddCorrectWord(string word)
{
   if (!CorrectWordsList.Contains(word))
   {
       CorrectWordsList.Add(word);
       Debug.Log("Correct word added: " + word);
   }

   bool IsWordCorrect(string word)
{
   // Burada doğru kelimelerin kontrolünü yapabilirsiniz
   return word == "HEART" || word == "HEAT" || word == "HATE" || word == "HEAR" || word == "LATE" || word == "RATE" || word == "HEAL" || word == "TALE"; 
}
   */

}

