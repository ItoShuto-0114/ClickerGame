using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

[CreateAssetMenu(fileName = ("Datas/ObjectgradeUpData"))]
public class ObjectUpgradeDataBase : ScriptableObject
{
    [SerializeField] private List<ObjectUpgradeData> _objectUpgradeData;
    private Dictionary<int, ObjectUpgradeData> _dictionary = new();
    public void CreateDataBase()
    {
        _dictionary.Clear();
        foreach (ObjectUpgradeData data in _objectUpgradeData)
        {
            _dictionary.Add(data.ObjectLevel, data);
        }
    }
    public ObjectUpgradeData GetUpGradeData(int level)
    {
        if (_dictionary.TryGetValue(level, out var data))
        {
            return data;
        }
        else
        {
            return null;
        }
    }
}
