using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TutorialText : MonoBehaviour
{
    
    public GameObject Player;

    void Update()
    {
        handleText();
    }
    private void handleText()
    {
        
        
            GetComponent<TextMeshProUGUI>().text = "Press the Spacebar to Jump";
        

    }
}

