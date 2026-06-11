using System;
using UnityEngine;
[Serializable]
public class ObjectUpgradeData
{
    public int ObjectLevel => _objectLevel;
    public int ObjectReward => _objectReward;
    public int ObjectLevelCost => _objectLevelCost;
    [SerializeField] private int _objectLevel;
    [SerializeField] private int _objectReward;
    [SerializeField] private int _objectLevelCost;
}
    
