using UnityEngine;
using System;
[Serializable]
public class PowerUpgradedeta
{
    public int PowerLevel => _powerLevel;//powerのLv
    public int Power => _power;//ぱわー
    public int Cost => _powerCost;//必要なコスト

    [SerializeField] private int _powerLevel;
    [SerializeField] private int _power;
    [SerializeField] private int _powerCost;
}
