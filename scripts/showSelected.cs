using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class showSelected : MonoBehaviour
{
    public TMP_Text Selectedtext;
    private SelectionManager selection;
    // Start is called before the first frame update
    void Start()
    {
        selection = GetComponent<SelectionManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (selection.tag == "Selectable")
        {

        }  
    }
}
