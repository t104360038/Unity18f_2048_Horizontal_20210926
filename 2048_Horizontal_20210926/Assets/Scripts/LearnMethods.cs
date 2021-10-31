using UnityEditor.Build.Reporting;
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
        Drive(100,"咻咻咻");
        Drive(200,"轟轟轟","炸彈");               //speed,sound
        Drive(30,effect: "石頭");       //speed,effect 
        // 時數 30，特效，石頭
        // 指定預設參數語法，參數名稱 冒號 值

        //Case A
        int t = Ten();
        print("傳回方法值:" + t);
        //Case B
        print("不使用變數儲存傳回值:" + Ten());
        int a=90,b =30;
        int damage = Damage(a,b);
        print("傷害值"+ damage);
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

    // 定義方法
    // 參數 : 資料類型 參數名稱 (指定 = 預設值) 寫在()最右邊
    // 多參數 
    public void Drive(int speed,string sound = "咻咻咻" ,string effect = "灰塵")
    {
        print("車速" + speed);
        print("音效" + sound);
        print("特效" + effect);
    }
    // 有傳回類型方法必須使用 return   // Case A
    public int Ten()
    {
        return 10;
    }
    /// <summary>
    /// 計算傷害值，攻擊力 - 防禦力 = 傷害值
    /// </summary>
    /// <param name="attack"></param>
    /// <param name="defence"></param>
    /// <returns>傷害值</returns>
    public int Damage(int attack, int defence)
    {
        return attack - defence;
    }
}
