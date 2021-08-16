using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class cardDisplay : MonoBehaviour
{
    public InfoCard card;
    public TMP_Text nameText;
    public TMP_Text descriptionText;

    public SelectionManager selectionmanager;


    //public Image diagramImage;
    void Start()
    {
        selectionmanager = GetComponent<SelectionManager>();
        nameText.text = card.name;
        descriptionText.text = card.description;

        //diagramImage.sprite = card.diagram;
    }
    private void Update()
    {
        //selectionmanager.checkCards();
        
    }
    /*else
    {
        //Selectedtext.enabled = false; //Text not here
          nameText.enabled = false;
                descriptionText.enabled = false;
    }*/
}


