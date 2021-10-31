using UnityEngine;

public class LearnIF : MonoBehaviour
{
    public bool OpenDoor;
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
}
