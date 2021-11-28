using UnityEngine;
using System.Linq; // LinQ Query 查詢語言 ，資料查詢

/// <summary>
/// 認識二為陣列
/// </summary>
public class Learn2DArray : MonoBehaviour
{
    // 一維陣列
    public int[] numbers = { 1,3,5,7,9 };
    // 二維陣列
    public int[,] block = { { 00,01,30 }, {10,11,12 }, { 20,21,22 } , { 30,31,32 }};

    public string[,] objects = new string[2, 4];

    private void Start()
    {
        #region 存取
        
        // 一維陣列存取
        numbers[0] = 4;
        print("一維陣列第五筆資料 : "+ numbers[4]);

        // 二維陣列存取
        print("一維陣列第二列第一欄 1, 0 :" + block[1,0]);

        // 獲取長度  一維  Length
        //          二維的第一維  GetLength(0)
        //          二維的第二維  GetLength(1)
        print("一維陣列維度長度 : " + numbers.Length);
        print("二維陣列第一維長度 : " + block.GetLength(0) );
        print("二維陣列第二維長度 : " + block.GetLength(1) );

        string result = "";

        for (int i = 0; i < block.GetLength(0); i++)
        {
            for (int j = 0; j < block.GetLength(1); j++)
            {
                result += block[i, j] + "|";
            }
            result += "\n";
        }
        print("result : \n" + result);
        #endregion
        #region 資料搜尋


        // 搜尋 numbers 一維陣列內大於等於 10 的資料
        // var 無類型資料型態
        // from 資料A in 陣列名稱     - 從陣列搜尋資料並保存為 資料A
        // where 資料A 條件          - 判斷 資料A 是否符合條件
        // selecr 資料A;             - 選取 符合條件的 資料A
        var numberGratgerTen = //集合
            from int n in numbers
            where n >= 10
            select n;

        print("符合 >= 10 資料有幾筆: " + numberGratgerTen.Count());
        for (int i = 0; i < numberGratgerTen.Count(); i++)
        {
            print(">= 10 的資料為: " + numberGratgerTen.ToArray()[i]);
        }
        #endregion

        // scores 不及格的分數有哪些
        var noPass =
            from int no in block
            where no < 11
            select no;
        for (int i = 0; i < noPass.Count(); i++)
        {
            print("不及格的分數 " + noPass.ToArray()[i]);
        }
    }
}
