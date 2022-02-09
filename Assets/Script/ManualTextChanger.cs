using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManualTextChanger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;
    // Start is called before the first frame update
    public void ChangerText()
    {
        textComponent.text = "Pas d'idée frère";
    }
}
