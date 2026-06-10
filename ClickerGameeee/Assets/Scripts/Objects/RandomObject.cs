using UnityEngine;

public class RandomObject : MonoBehaviour
{
    [SerializeField] public GameObject _prefabObject;
    float _timer;
    [SerializeField] float _interval = 15;
    Vector3 _center;
    void Start()
    {
      
    }
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= _interval)
        {
            RandomPos();
            _timer = 0;
        }
    }
    void RandomPos()
    {
        Vector2 _center = transform.position;
        float x = Random.Range(-8.0f, 8.0f);
        float y = Random.Range(-4.0f, 4.0f);
        Vector2 pos =_center + new Vector2(x, y);
        Instantiate(_prefabObject, pos, Quaternion.identity);
    }
}
