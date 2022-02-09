using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangementText : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI textComponent;
    void Start()
    {
        StartCoroutine(changeText("New title"));
    }

    private IEnumerator changeText(string content)
    {
        yield return new WaitForSeconds(5f);
        textComponent.text = content;
    }
}
