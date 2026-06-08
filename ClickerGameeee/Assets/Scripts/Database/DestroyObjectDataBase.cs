using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = ("Datas/ObjectData"))]
public class DestroyObjectDataBase : ScriptableObject
{
    [SerializeField] private List<ObjectData> _objectDatas;
}
