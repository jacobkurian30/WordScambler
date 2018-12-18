using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlazzleBlockImplement : MonoBehaviour
{

    public GameObject buttonPrefab;
    public Transform buttonContainer;
    private int rowWidth = 0;


    private GameObject objectOne;
   //TODO create object after the other one land on the 0.

    // Use this for initialization
    void Start()
    {
        CanvasElements canvasElements = SetCanvasElement();

        objectOne = createAlphabet("B", canvasElements);
        rowWidth += Constants.SQUARE_SIDE;
        createAlphabet("C", canvasElements);
        rowWidth += Constants.SQUARE_SIDE;
        createAlphabet("D", canvasElements);
    }

    private static CanvasElements SetCanvasElement()
    {
        CanvasElements canvasElements = new CanvasElements
        {
            Screen_height = Screen.height,
            Screen_width = Screen.width
        };
        return canvasElements;
    }

    public GameObject createAlphabet(string letter, CanvasElements canvasElements)
    {
        GameObject gameObject = Instantiate(buttonPrefab) as GameObject;
        gameObject.transform.SetParent(buttonContainer);
        gameObject.transform.position = new Vector3(rowWidth + Constants.SQUARE_SIDE / 2, canvasElements.Screen_height, 0);
        gameObject.GetComponentInChildren<Text>().text = letter;
        return gameObject;
    }


    void Update()
    {
        objectOne.transform.position = new Vector3(objectOne.transform.position.x, objectOne.transform.position.y - 1, 0);
    }

    public void Setup()
    {

    }

    public void HandleClick()
    {

    }
}
