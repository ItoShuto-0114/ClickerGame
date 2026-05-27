using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    ball _ball;
   [SerializeField] public TextMeshProUGUI _countUI;
    public  int _kickCount = 0;
    void Start()
    {
        
    }

    
    void Update()
    {
        _countUI.text = _kickCount.ToString(); 
    }
}
