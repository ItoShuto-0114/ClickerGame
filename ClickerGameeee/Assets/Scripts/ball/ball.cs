using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] GameObject _ball;
    Rigidbody2D _rb;
    Vector2 _mousePos;
    Vector2 _dir;
    Vector2 _velo;
    float _ballSpeed;
    [SerializeField]GameManager _gm;
    [SerializeField] private UpGradeDetaBase _dataBase;
    [SerializeField] UpGradeManager _ugm;
    private void Awake()
    {
       _dataBase.CreateDataBase();
    }
    void Start()
    {
        _rb= GetComponent<Rigidbody2D>();
    }
    public static Vector2 RandomVector2()
    {
        Vector2 v = Vector2.zero;
        v.x = Random.Range(-1.0f, 1.0f);
        v.y = Random.Range(-1.0f, 1.0f);
        return v.normalized;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(_mousePos, Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject == gameObject)
                {
                    Kick();
                }
            }
        }
        
    }
    private void FixedUpdate()
    {
        _velo = _rb.linearVelocity;
        _ballSpeed = _velo.magnitude;
        transform.Rotate(0, 0, -_ballSpeed * 10f * Time.deltaTime);
    }

    public void Kick()
    {
        UpGradedeta data = _dataBase.GetUpGradeData(_ugm.CurrentLevel);
       Debug.Log(data.Power);
        _dir = RandomVector2();
       _rb.AddForce(_dir * data.Power);
        _gm._kickCount++;
    }
}
