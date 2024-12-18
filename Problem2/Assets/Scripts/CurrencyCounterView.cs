using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyCounterView : MonoBehaviour
{
    [SerializeField] private Image currencyIcon;
    [SerializeField] private TMP_Text currencyText;
    [SerializeField] private Button addCurrencyButton;

    public Action OnAddCurrencyClicked;

    void Start()
    {
        if (addCurrencyButton != null)
        {
            addCurrencyButton.onClick.AddListener(() => OnAddCurrencyClicked?.Invoke());
        }
    }
    
    public void UpdateCurrencyText(string newCurrencyText)
    {
        currencyText.text = newCurrencyText;
    }
}
