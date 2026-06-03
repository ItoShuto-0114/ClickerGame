using UnityEngine;
using System;
[Serializable]
public class UpGradedeta
{
    public int Level => _level;
    public int Power => _power;

    [SerializeField] private int _level;
    [SerializeField] private int _power;
}
