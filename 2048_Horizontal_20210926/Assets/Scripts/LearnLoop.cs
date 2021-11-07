using UnityEngine;

public class LearnLoop : MonoBehaviour
{
    public int number= 0;
    public int numberEnd = 5;

    public int Count = 0;
    public int CountEnd = 10;
    void Start()
    {
        //  迴圈: 重複執行
        //  while 迴圈語法:
        //  while (布林值) { 當布林值等於 true 會執行 持續到布林值為 faulse 程式內容 }
        while (number < numberEnd +1)
        {   
            print("while 迴圈數字: " + number );
            number++;
        }

        //  for (初始值; 布林值; 迴圈結束執行程式敘述)
        for (int x = Count; x < CountEnd +1; x++)    //快速變數 對x按 tab
        {
            print("For 迴圈數字: " + x);
        }
    }

}
