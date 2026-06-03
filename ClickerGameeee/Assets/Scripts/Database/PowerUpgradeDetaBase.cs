using System.Collections.Generic;
using UnityEngine;


    [CreateAssetMenu(fileName =("Datas/UpGradeData"))]
public class PowerUpgradeDetaBase : ScriptableObject
{
    [SerializeField] private List<PowerUpgradedeta> _powerUpGradeDetas;

    private Dictionary<int, PowerUpgradedeta> _dictionary = new();

    public void CreateDataBase()
    {
        _dictionary.Clear();
        foreach (PowerUpgradedeta data in _powerUpGradeDetas)
        {
            _dictionary.Add(data.PowerLevel, data);
        }
    }
    public PowerUpgradedeta GetUpGradeData(int level)
    {
        if(_dictionary.TryGetValue(level, out var data))
        {
            return data;
        }
        else
        {
            return null;
        }
       
    }
}
