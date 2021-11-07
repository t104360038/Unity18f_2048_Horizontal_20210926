using UnityEngine;

public class LearnPropertyStatic : MonoBehaviour
{
    public float Random_No ;
    public float Random_Mutiple;
    public int Card_no;
    public int[] Card_Type = new int[4];

    private void Start()
    {
    //    Random_No = Random.value;
        //  靜態屬性 Static Property
        //  取得靜態屬性
        //  語法:類別名稱.靜態屬性名稱
    //    print("隨機值: " + Random_No);

        //  設定靜態屬性
    //    print("全部攝影機數量: " + Camera.allCamerasCount);

        //  Cursor.visible = false;
        //  print("Floor(無條件刪除): " + Mathf.Floor(Random_No));
        //  print("Round(四捨五入): " + Mathf.Round(Random_No));

        for (int i = 0; i < Card_no; i++)
        {
            Random_Mutiple = Random.value;

            //  抽卡 0.01=SSR 0.09=SR 0.30=R 0.60=N
            switch (Random_Mutiple)
            {
                case float Random_Mutiple when (Random_Mutiple <= 0.01):
                    print("恭喜抽到SSR !");
                    Card_Type[0]++;
                    break;
                case float Random_Mutiple when (Random_Mutiple > 0.01 && Random_Mutiple <= 0.1):
                    print("恭喜抽到SR !");
                    Card_Type[1]++;
                    break;
                case float Random_Mutiple when (Random_Mutiple > 0.1 && Random_Mutiple <= 0.4):
                    print("抽到R !");
                    Card_Type[2]++;
                    break;
                case float Random_Mutiple when (Random_Mutiple > 0.4 && Random_Mutiple <= 1):
                    print("抽到N ");
                    Card_Type[3]++;
                    break;
            }
        }
        print("SSR 共" + Card_Type[0] +"張" + "SR 共" + Card_Type[1] + "張" + "R 共" + Card_Type[2] + "張" + "N 共" + Card_Type[3] + "張");
    }
}