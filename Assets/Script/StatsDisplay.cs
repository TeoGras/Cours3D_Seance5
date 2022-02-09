using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatsDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textcomponent;
    [SerializeField] private WeaponObject _statsDisplay;

    private void Awake()
    {
        _textcomponent.text = $"damage : {_statsDisplay.damage} range : {_statsDisplay.range} Fire Rate : {_statsDisplay.rateOfFire}";
    }
}
