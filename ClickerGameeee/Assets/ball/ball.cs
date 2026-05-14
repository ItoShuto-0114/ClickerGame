using UnityEngine;

public class ball : MonoBehaviour
{
    private Vector2 _mousePressPos;
    private Vector2 _mouseReleasePos;
    private Vector2 _dir;
    private bool _isDragging;
    Rigidbody2D _rb;
    void Start()
    {
        _rb= GetComponent<Rigidbody2D>();
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
    
    }
    void Kick()
    {
        _dir = _mousePressPos - _mouseReleasePos;
        _rb.linearVelocity = Vector2.zero;
        _rb.AddForce(_dir * 5f, ForceMode2D.Impulse);
    }
}
