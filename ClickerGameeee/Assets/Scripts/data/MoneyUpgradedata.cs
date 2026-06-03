using System;
using UnityEngine;
[Serializable]
public class MoneyUpgradedata
{
    public int MoneyLevel => _moneyLevel;//受け取る金額の倍率強化のLv
    public int Money => _money;//もらえる量
    public int Cost => _moneyCost;//必要なコスト

    [SerializeField] private int _moneyLevel;
    [SerializeField] private int _money;
    [SerializeField] private int _moneyCost;
}
