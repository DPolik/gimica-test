using UnityEngine;

public class CurrencyCounterPresenter : MonoBehaviour
{
    [SerializeField] private CurrencyCounterView view;
    [SerializeField] private CurrencyType type;
    [SerializeField] private int incrementAmount = 10;
    
    private CurrencyCounterModel _model;

    void Start()
    {
        // Initialize the model on start for this example, but it could come from other sources (SOs, managers, etc)
        _model = new CurrencyCounterModel
        {
            CurrencyType = type
        };

        if (view == null) return;
        // Initialize the view's values, color is setup in the editor though it could also be done here
        view.UpdateCurrencyText(_model.CurrencyAmount.ToString());
        view.OnAddCurrencyClicked += () => _model.CurrencyAmount += incrementAmount;
        _model.OnCurrencyChanged += (amount) => view.UpdateCurrencyText(amount.ToString());
    }
    
    
    
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length < 2) {
            return 0;
        }
        
        int minPrice = prices[0];
        int maxProfit = 0;
        
        for (int i = 1; i < prices.Length; i++) {
            // Update maxProfit if selling at prices[i] is better
            maxProfit = Mathf.Max(maxProfit, prices[i] - minPrice);
            // Update minPrice if a lower price is found
            minPrice = Mathf.Min(minPrice, prices[i]);
        }
        
        return maxProfit;
    }
}
