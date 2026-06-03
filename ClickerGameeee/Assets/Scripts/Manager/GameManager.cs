using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PowerUpgradeDetaBase _powerDataBase;
    [SerializeField] private MoneyUpgradeDataBase _moneyUpgradeDatabase;
    [SerializeField,Header("金UI")] TextMeshProUGUI _countUI; 
    [SerializeField,Header("PowerLvのUI")] TextMeshProUGUI _powerLevelUI;
    [SerializeField, Header("MoneyLvのUI")] TextMeshProUGUI _moneyLevelUI;
    [SerializeField] UpGradeManager _ugm;
    public int _money = 0;
    public int _powerCost = 0;
    public int _moneyCost = 0;
    public int _kickCount;
    private void Awake()
    {
        _powerDataBase.CreateDataBase();
        _moneyUpgradeDatabase.CreateDataBase();
    }
    void Update()
    {
        PowerUpgradedeta powerdata = _powerDataBase.GetUpGradeData(_ugm.CurrentPowerLevel);
        MoneyUpgradedata moneydata = _moneyUpgradeDatabase.GetUpGradeData(_ugm.CurrentMoneyLevel);
        if (powerdata == null || moneydata == null)
        {
            Debug.LogError("データねえよカス");
            return;
        }
        _powerCost = powerdata.Cost;
        _moneyCost = moneydata.Cost;
        _countUI.text = _money.ToString();
        _powerLevelUI.text = "Power Lv." + _ugm.CurrentPowerLevel.ToString();
        _moneyLevelUI.text = "Money Lv." + _ugm.CurrentMoneyLevel.ToString();
    }
}
  