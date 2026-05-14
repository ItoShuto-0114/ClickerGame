using UnityEngine;

public class ball : MonoBehaviour
{
    private Vector2 _mousePressPos;
    private Vector2 _mouseReleasePos;
    private Vector2 _dir;
    private bool _isDragging;
    [SerializeField]private float _maxX = 10;
    [SerializeField]private float _minX = -10;
    Vector2 _pos;
    Rigidbody2D _rb;
    Transform _tr;
    
    void Start()
    {
        _rb= GetComponent<Rigidbody2D>();
        _tr= GetComponent<Transform>();

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _mousePressPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); ;
            _isDragging = true;
        }
        if (Input.GetMouseButton(0) && _isDragging)
        {
            _mouseReleasePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.GetMouseButtonUp(0)&&_isDragging)
        {
            Kick();
            _isDragging=false;
        }
        _pos = transform.position;
        _pos.x = Mathf.Clamp(_pos.x,_minX,_maxX);
        transform.position = _pos;
    }
    void Kick()
    {
        _dir = _mousePressPos - _mouseReleasePos;
        _rb.linearVelocity = Vector2.zero;
        _rb.AddForce(_dir * 5f, ForceMode2D.Impulse);
    }
}
