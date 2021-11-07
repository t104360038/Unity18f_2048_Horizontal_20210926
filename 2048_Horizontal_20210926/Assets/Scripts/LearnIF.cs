using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class LearnIF : MonoBehaviour
{
    public bool OpenDoor;
    public int score = 99;

    private void Start()
    {
        // 判斷式 if else
        // 語法
        // 如果 (判斷) {執行程式內容}
        // 否則 { 當布林值 等於 false 會執行 程式內容}
        if (true)
        {
            print("布林值 true");
        }

        // opendoor == true 與 OpenDoor
        if (OpenDoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }
    }
    public void Update()
    {
        //如果分數 >= 60 分 及格
        if (score >= 60)
        {
            print("及格");
        }
        // 如果分數 >= 40 補考
        //語法: else if (布林值) {布林值 為true 時執行}
        // else if 放在 if 下方與 else 上方 ，可以無線個
        else if (score >= 40)
        {
            print("補考");
        }
        // 如果分數 < 40分 死當
        else
        {
            print("死當");
        }
    }

}
