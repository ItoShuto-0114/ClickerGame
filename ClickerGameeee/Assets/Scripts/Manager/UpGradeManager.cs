using UnityEngine;

public class UpGradeManager : MonoBehaviour
{
    [SerializeField]GameManager _gm;
   public void UpGrade()
    {
        _gm._status._level++;
        _gm._status._power += 50;
    }
}
