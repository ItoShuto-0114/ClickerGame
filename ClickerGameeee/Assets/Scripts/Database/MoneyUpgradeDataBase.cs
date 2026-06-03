using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = ("Datas/UpGradeData"))]
public class MoneyUpgradeDataBase : ScriptableObject
{
    [SerializeField] private List<MoneyUpgradedata> _moneyUpGradeDetas;//inspectorに表示されるリスト

    private Dictionary<int, MoneyUpgradedata> _dictionary = new();//レベルとデータを対応付けて保持するDictionary

    public void CreateDataBase()//リストの内容からDictionaryを作成する
    {
        _dictionary.Clear();//_dictionaryを空にする
        foreach (MoneyUpgradedata data in _moneyUpGradeDetas)//_moneyUpGradeDetasの中身を取り出す
        {
            _dictionary.Add(data.MoneyLevel, data);//レベルをキーとしてデータを登録
        }
    }
    public MoneyUpgradedata GetUpGradeData(int level)//レベルを渡すと対応するデータを返す関数
    {
        if (_dictionary.TryGetValue(level, out var data))//指定したレベルのデータを取得する
        {
            return data;//そのデータを返す
        }
        else
        {
            return null;//見つからなかったらnullを返す
        }

    }
}
