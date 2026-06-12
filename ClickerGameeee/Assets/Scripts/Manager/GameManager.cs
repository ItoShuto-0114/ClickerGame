using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PowerUpgradeDetaBase _powerDataBase;
    [SerializeField] private MoneyUpgradeDataBase _moneyUpgradeDatabase;
    [SerializeField] private BreakObjectDataBase _objectData;
    [SerializeField] private ObjectUpgradeDataBase _objectUpgradeDatabase;
    [SerializeField,Header("金UI")] TextMeshProUGUI _countUI; 
    [SerializeField,Header("PowerLvのUI")] TextMeshProUGUI _powerLevelUI;
    [SerializeField, Header("MoneyLvのUI")] TextMeshProUGUI _moneyLevelUI;
    [SerializeField, Header("ObjectLvのUI")] TextMeshProUGUI _objectLevelUI;
    [SerializeField] UpGradeManager _ugm;
    [SerializeField] TextMeshProUGUI _powerUpButtonText;
    [SerializeField] TextMeshProUGUI _moneyUpButtonText;
    [SerializeField] TextMeshProUGUI _objectUpButtonText;
    public int _money = 0;
    public int _powerCost = 0;
    public int _moneyCost = 0;
    public int _objectLevelCost = 0;
    public int _kickCount;
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        _powerDataBase.CreateDataBase();
        _moneyUpgradeDatabase.CreateDataBase();
        _objectData.CreateDataBase();
        _objectUpgradeDatabase.CreateDataBase();
    }
    void Update()
    {
        PowerUpgradedeta powerdata = _powerDataBase.GetUpGradeData(_ugm.CurrentPowerLevel);
        MoneyUpgradedata moneydata = _moneyUpgradeDatabase.GetUpGradeData(_ugm.CurrentMoneyLevel);
        ObjectUpgradeData objectdata = _objectUpgradeDatabase.GetUpGradeData(_ugm.CurrentObjectLevel);
        if (powerdata == null || moneydata == null || objectdata == null)
        {
            Debug.LogError("データねえよカス");
            return;
        }
        _powerCost = powerdata.Cost;
        _moneyCost = moneydata.Cost;
        _objectLevelCost = objectdata.ObjectLevelCost;
     UpdateUI();
    }
    void UpdateUI()
    {
        _countUI.text =_money.ToString();
        _powerLevelUI.text = "Power Lv." + _ugm.CurrentPowerLevel.ToString();
        _moneyLevelUI.text = "Money Lv." + _ugm.CurrentMoneyLevel.ToString();
        if (_money < _powerCost)
        {
            _powerUpButtonText.color = Color.red;
        }
        else
        {
            _powerUpButtonText.color = Color.black;
        }
        if (_money < _moneyCost)
        {
            _moneyUpButtonText.color = Color.red;
        }
        else
        {
            _moneyUpButtonText.color = Color.black;
        }
    }
}
  