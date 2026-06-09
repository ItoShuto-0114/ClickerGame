using UnityEngine;

public class BreakObject : MonoBehaviour
{
    [SerializeField] ObjectType _type;
    [SerializeField]private BreakObjectDataBase _objectDataBase;
    [SerializeField] GameManager _gm;
    private ObjectData _data;
    int _hp;
    int _reward;
    
    private void Start()
    {
        _data = _objectDataBase.GetupDataBase(_type);
        _hp = _data.Hp;
        _reward = _data.Reward;
    }

    public void TakeDamage(int damage)
    {
        _hp -= damage;
        if (_hp <= 0)
        {
            Broken();
        }
    }
    public void Broken()
    {
        Destroy(gameObject);
        _gm._money += _reward;

    }
}
