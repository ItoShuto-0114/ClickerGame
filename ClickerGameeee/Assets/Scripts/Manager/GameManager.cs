using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   [SerializeField] TextMeshProUGUI _countUI;
    [SerializeField] TextMeshProUGUI _levelUI;
    public UpGradedeta _status;
    [SerializeField] UpGradeManager _ugm;
    public int _kickCount = 0;
    void Start()
    {
       
    }

    
    void Update()
    {
        _countUI.text = _kickCount.ToString();
        _levelUI.text = "Lv." +_status._level.ToString();
        
    }
}
