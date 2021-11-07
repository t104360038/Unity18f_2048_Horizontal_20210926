using UnityEngine;

/// <summary>
/// 列舉: 下拉式選單
/// </summary>
public class LearnEnumeration : MonoBehaviour
{
    //  1. 定義列舉
    //  語法: 修飾詞 列舉 列舉名稱 { 列舉1, 列舉2 列舉3....}
    public enum StateEnum
    {
        Idle, Walk, Attack, Dead
    }
    //  2. 使用列舉
    //  語法: 修飾詞 列舉名稱 欄位名稱 指定 值;
    public StateEnum state = StateEnum.Walk;

    private void Update()
    {
        switch (state)
        {
            case StateEnum.Idle:
                print("等待");
                break;
            case StateEnum.Walk:
                print("走路");
                break;
            case StateEnum.Attack:
                print("攻擊");
                break;
            case StateEnum.Dead:
                print("死亡");
                break;
            default:
                break;
        }
    }
}
