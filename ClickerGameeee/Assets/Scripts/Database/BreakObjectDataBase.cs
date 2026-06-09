using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = ("Datas/ObjectData"))]
public class BreakObjectDataBase : ScriptableObject
{
    [SerializeField] private List<ObjectData> _objectDatas;
    private Dictionary<ObjectType, ObjectData> _dictionary = new();

    public void CreateDataBase()
    {
        _dictionary.Clear();
        foreach(ObjectData data in _objectDatas)
        {
            _dictionary.Add(data.Type, data);
        }
    }
    public ObjectData GetupDataBase(ObjectType type)
    {
        if (_dictionary.TryGetValue(type, out var data))
        {
            return data;
        }
        else
        {
            return null;
        }
    }
}
