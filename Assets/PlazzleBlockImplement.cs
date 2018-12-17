using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlazzleBlockImplement : MonoBehaviour
{
    
    public GameObject buttonPrefab;
    public Transform buttonContainer;


    

    // Use this for initialization
    void Start()
    {
       // GameObject gameObject = (GameObject)Resources.Load("button", typeof(GameObject)); 
        GameObject gameObject = Instantiate(buttonPrefab) as GameObject;
        gameObject.transform.SetParent(buttonContainer);
        gameObject.GetComponentInChildren<Text>().text =  "Hellow wordl";
    }

    public void Setup()
    {
        
    }

    public void HandleClick()
    {
        
    }
}
