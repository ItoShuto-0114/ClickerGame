using UnityEngine;

public class ball : MonoBehaviour
{
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("èRÇËÇ‚Ç™Ç¡ÇΩÇ»");
                Kick();
            }
        }
    
    }
    void Kick()
    {
        Destroy(gameObject);
    }
}
