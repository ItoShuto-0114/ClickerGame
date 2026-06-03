using System.Collections.Generic;
using UnityEngine;


    [CreateAssetMenu(fileName =("Datas/UpGradeData"))]
public class UpGradeDetaBase : ScriptableObject
{
    [SerializeField] private List<UpGradedeta> _upGradeDetas;

    private Dictionary<int, UpGradedeta> _dictionary = new();

    public void CreateDataBase()
    {
        _dictionary.Clear();
        foreach (UpGradedeta data in _upGradeDetas)
        {
            _dictionary.Add(data.Level, data);
        }
    }
    public UpGradedeta GetUpGradeData(int level)
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
