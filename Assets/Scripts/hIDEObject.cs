using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hIDEObject : MonoBehaviour
{
    public GameObject gejmobjekt;
    public GameObject gejmobjekt2;
    public GameObject canwas;
    public Image imejdz;
    public Text codetext;
    public Text errorstext;
    public GameObject StopButton;
    public void HideObject()
    {
        string coodete = codetext.text;
        var lines = coodete.Split('\n');
        var specificLine = lines[0];
        bool missileEnabled = false;
        bool planetEnabled = false;
        bool DoRepeat = true;
        Debug.Log(codetext.text.Split('\n').Length);
        int i = 0;
        while (DoRepeat == true)
        {

            specificLine = lines[i];
            Debug.Log(specificLine);
            if (specificLine == "print('planet')")
            {
                Debug.Log("FoundPlanet");
                planetEnabled = true;
                
            }
            else if (specificLine == "print('missile')")
            {
                Debug.Log("FoundMissile");
                missileEnabled = true;
            }
            i++;
            if (i == codetext.text.Split('\n').Length)
            {
                DoRepeat = false;
            }
        }
        if (missileEnabled == true)
        {
            
          gejmobjekt2.SetActive(true);
                canwas.SetActive(false);
                StopButton.SetActive(true);
                imejdz.enabled = false;
         
        }
        if (planetEnabled == true)
        {
            gejmobjekt.SetActive(true);
            canwas.SetActive(false);
            StopButton.SetActive(true);
            imejdz.enabled = false;
        }
        else
        {
            if (missileEnabled == false)
            {
                errorstext.text += Environment.NewLine + "Unexcepted keyword: " + codetext.text;
            }
            
        }
    }
    public void RevertEditor()
    {
        StopButton.SetActive(false);
        imejdz.enabled = true;
        canwas.SetActive(true);
        gejmobjekt.SetActive(false);
        gejmobjekt2.SetActive(false);
    }
}
