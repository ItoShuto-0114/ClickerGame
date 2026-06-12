using UnityEngine;

public class UpGradeManager : MonoBehaviour
{
    public int CurrentPowerLevel => _currentPowerLevel;
    private int _currentPowerLevel = 1;
    public int CurrentMoneyLevel => _currentMoneyLevel;
    private int _currentMoneyLevel = 1;
    public int CurrentObjectLevel => _currentObjectLevel;
    private int _currentObjectLevel = 1;

    public void PowerUpGrade()
    {
        if (GameManager.Instance._money < GameManager.Instance._powerCost)
        {
            Debug.Log("レベルアップできねえよ");
            return;
        }

        _currentPowerLevel++;
        GameManager.Instance._money -= GameManager.Instance._powerCost;
    }
    public void MoneyUpGrade()
    {
        if (GameManager.Instance._money < GameManager.Instance._moneyCost)
        {
            Debug.Log("レベルアップできねえよ");
            return;
        }
        _currentMoneyLevel++;
        GameManager.Instance._money -= GameManager.Instance._moneyCost;
    }
    public void ObjectLevelUpGrade()
    {
        if(GameManager.Instance._money < GameManager.Instance._objectLevelCost)
        {
            Debug.Log("レベルアップできねえよ");
            return;
        }
        _currentObjectLevel++;
        GameManager.Instance._money -= GameManager.Instance._objectLevelCost;
    }
}
