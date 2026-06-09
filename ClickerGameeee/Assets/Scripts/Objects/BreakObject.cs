using UnityEngine;

public class BreakObject : MonoBehaviour
{
    [SerializeField] ObjectType _type;
    [SerializeField]private BreakObjectDataBase _objectDataBase;
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
        Debug.Log("Žc‚èHP‚Í" + _hp);
        if (_hp <= 0)
        {
            Broken();
        }
    }
    public void Broken()
    {
        Debug.Log("”j‰ó");
        Destroy(gameObject);
        GameManager.Instance._money += _reward;

    }
}
