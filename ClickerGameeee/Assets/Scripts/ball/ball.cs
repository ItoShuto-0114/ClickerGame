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
    [SerializeField] private PowerUpgradeDetaBase _powerDataBase;
    [SerializeField] private MoneyUpgradeDataBase _moneyDataBase;
    [SerializeField] UpGradeManager _ugm;
    private void Awake()
    {
       _powerDataBase.CreateDataBase();
        _moneyDataBase.CreateDataBase();
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
        PowerUpgradedeta powerdata = _powerDataBase.GetUpGradeData(_ugm.CurrentPowerLevel);
        MoneyUpgradedata moneydata = _moneyDataBase.GetUpGradeData(_ugm.CurrentMoneyLevel);

        //Debug.Log(powerdata.Power);
        _dir = RandomVector2();
       _rb.AddForce(_dir * powerdata.Power);
        _gm._kickCount++;
        _gm._money +=moneydata.Money;
        Debug.Log(moneydata.Money);
    }
}
