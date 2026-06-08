using System;
using UnityEngine;

public enum ObjectType
{
    Wood,
    Stone,
    Iron


}

[Serializable]
public class ObjectData
{
    public ObjectType Type => _type;
    public int Hp => _hp;
    public int Reward => _reward;

    [SerializeField] private ObjectType _type;
    [SerializeField] private int _hp;
    [SerializeField] private int _reward;
}
