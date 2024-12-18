using System;

public enum CurrencyType
{
    Gold,
    Energy,
    Crystal
}

public class CurrencyCounterModel
{
    public CurrencyType CurrencyType { get; set; }
    
    private int _currencyAmount;
    public int CurrencyAmount {
        get => _currencyAmount;
        set
        {
            _currencyAmount = value;
            OnCurrencyChanged?.Invoke(_currencyAmount);
        }
    }
    public Action<int> OnCurrencyChanged;
}
