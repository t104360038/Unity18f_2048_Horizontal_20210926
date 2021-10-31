using UnityEngine;

public class LearnMethods : MonoBehaviour
{
    // Methods 方法: Funetion (函式)
    // 作用: 執行較複雜的程式內容
    // 語法:
    // 修飾詞 傳回資料類型 方法名稱(參數){ 程式內容 }
    // 無傳回 void
    // 命名習慣: Unity 方法以大寫開頭
    // 自訂方法: 不會執行
    public void Test()
    {
        print("I'm Test Methods!");
    }
    private void Start()
    {
        //呼叫方式: 方法名稱();
        Test();
        Drive150();
        Drive100();
        Drive(69);
        Drive(99);
    }

    // 企劃需求
    // 播放音效
    // 汽車可以加速，時速為 90;
    // 汽車可以加速，時速為 90;
    public void Drive150()
    {
        print("Car_Speed: " + 150);
        print("Sound!");
    }
    public void Drive100()
    {
        print("Car_Speed: " + 100);
        print("Sound!");
    }
    public void Drive(int speed)
    {
        print("Car_Speed" + speed);
        print("Sound!");
    }
}
