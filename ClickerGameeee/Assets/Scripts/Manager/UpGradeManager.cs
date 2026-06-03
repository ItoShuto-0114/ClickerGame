using UnityEngine;

public class UpGradeManager : MonoBehaviour
{
    public int CurrentLevel => _currentLevel;
    private int _currentLevel = 1;
    
    public void UpGrade()
    {
        _currentLevel++;
    }
}
