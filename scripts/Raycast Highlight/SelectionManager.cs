﻿﻿﻿using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectionManager : MonoBehaviour
{
    private IRayProvider _rayProvider;
    private ISelector _selector;
    private ISelectionResponse _selectionResponse;

    //public string[] descText;
    private Transform _currentSelection;

    public TMP_Text nameText;
    public TMP_Text descriptionText;

    //public Image diagramImage;

    private void Awake()
    {
        _rayProvider = GetComponent<IRayProvider>();
        _selector = GetComponent<ISelector>();
        _selectionResponse = GetComponent<ISelectionResponse>();
        //string[] descText = {"RibCage", "testmodel", "Foot","Brain","Cube" };
    }

    private void Update()
    {
        if (_currentSelection != null)
        {
            _selectionResponse.OnDeselect(_currentSelection);

        }

        _selector.Check(_rayProvider.CreateRay());
        _currentSelection = _selector.GetSelection();

        if (_currentSelection != null)
        {
            _selectionResponse.OnSelect(_currentSelection);
            checkCards();
           
        } 
    }
    public void checkCards()
    {
        nameText.text = _currentSelection.gameObject.name;
        switch (_currentSelection.gameObject.name) // expression ie. name of the object selected
        {

            case "RibCage":
                descriptionText.text = "peepeeppoopoo";
                break;

            case "why":
                descriptionText.text = "Model";
                break;

            case "Brain":
                descriptionText.text = "Braiinz";
                break
                    ;
            case "Skeletal Foot":
                descriptionText.text = "Toes";
                break;

            case "Cube":
                descriptionText.text = "Square";
                break;

            default: //if looking at something not in other cases
                nameText.text = "default name";
                descriptionText.text = "default description text";
                break;


        }
    }
}
