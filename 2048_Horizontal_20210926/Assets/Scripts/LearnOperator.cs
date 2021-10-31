using UnityEngine;

/// <summary>
/// 認識運算子
/// 1.指定
/// 2.數學
/// 3.比較
/// 4.邏輯
/// </summary>

public class LearnOperator : MonoBehaviour
{

    public float a = 10;
    public float b = 3;
    public int c = 30;
    public int d = 100;


    private void Start()
    {
        #region 指定運算子
        // 指定 =
        // 先執行指定運算子右側再指定值給左側
        #endregion
        #region 數學運算子
        // 加減乘除餘
        // + - * / %
        print("取餘數:" + (a % b));    // 結果為1
        #endregion
        #region 比較運算子
        // 大於 小於 大等於 小等於 等於 不等於
        // >    <   >=      <=    ==    !=
        // 比較兩個值，並且得到布林值結果
        print("a > b"+ (a > b)); //True
        print("a >= b" + (a >= b)); //True
        #endregion
        #region 邏輯運算子
        // 並且，或者，顛倒
        // && ， || ， !
        // 並且，或者
        // 比較兩個布林值，並且得到布林值結果
        // 並且&& : 有0為0 --只要有一個 F 結果就是 F
        print("t && t" + (true && true));        // t
        print("f && t" + (false && true));       // f
        print("t && f" + (true && false));       // f
        print("f && f" + (false && false));      // f
        // 或者|| : 有1為1 --只要有一個 T 結果就是 T
        print("t || t" + (true || true));        // t
        print("f || t" + (false || true));       // t
        print("t || f" + (true || false));       // t
        print("f || f" + (false || false));      // f
        // Alt + shift + > 快速選取----------------------------------
        // 顛倒: 只能加在布林值前面
        print(!true);                           // F
        print(!(false && true));                // T
        #endregion
    }


}
