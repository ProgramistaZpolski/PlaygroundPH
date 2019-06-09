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
        if (codetext.text == "print('planet')")
        {
            gejmobjekt.SetActive(true);
            canwas.SetActive(false);
            StopButton.SetActive(true);
            imejdz.enabled = false;
        }
        else if (codetext.text == "print('missile')")
        {
            gejmobjekt2.SetActive(true);
            canwas.SetActive(false);
            StopButton.SetActive(true);
            imejdz.enabled = false;
        }
        else
        {
            errorstext.text += Environment.NewLine + "Unexcepted keyword: " + codetext.text;
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
