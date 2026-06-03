using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UpGradeDetaBase _dataBase;
   [SerializeField] TextMeshProUGUI _countUI; 
    [SerializeField] TextMeshProUGUI _levelUI;
    [SerializeField] TextMeshProUGUI _powerUI;
    [SerializeField] UpGradeManager _ugm;
    public int _kickCount = 0;
    private void Awake()
    {
        _dataBase.CreateDataBase();
    }
    void Update()
    {
        _countUI.text = _kickCount.ToString();
        _levelUI.text = "Lv." +_ugm.CurrentLevel.ToString();  
        UpGradedeta data = _dataBase.GetUpGradeData(_ugm.CurrentLevel);
        _powerUI.text = data.Power.ToString();
    }
}
