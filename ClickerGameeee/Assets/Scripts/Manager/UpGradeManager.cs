using UnityEngine;

public class UpGradeManager : MonoBehaviour
{
    public int CurrentPowerLevel => _currentPowerLevel;
    private int _currentPowerLevel = 1;
    public int CurrentMoneyLevel => _currentMoneyLevel;
    private int _currentMoneyLevel = 1;
    [SerializeField] GameManager _gm;
    
    public void PowerUpGrade()
    {
        if (_gm._money < _gm._powerCost)
        {
            Debug.Log("レベルアップできねえよ");
            return;
        }

        _currentPowerLevel++;
        _gm._money -= _gm._powerCost;
    }
    public void MoneyUpGrade()
    {
        if (_gm._money < _gm._moneyCost)
        {
            Debug.Log("レベルアップできねえよ");
            return;
        }
        _currentMoneyLevel++;
        _gm._money -= _gm._moneyCost;
    }
}
