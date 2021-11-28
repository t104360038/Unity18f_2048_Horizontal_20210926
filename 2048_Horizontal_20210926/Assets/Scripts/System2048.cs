using UnityEngine;
using System.Linq;
/// <summary>
/// 2048 系統
/// 儲存每個區塊資料
/// 管理隨機生成
/// 滑動控制
/// 數字合併判定
/// 遊戲機制判定
/// </summary>
public class System2048 : MonoBehaviour
{
    [Header("空白區塊")]
    public Transform[] blockEmpty;
    [Header("數字區塊")]
    public GameObject goNumberBlock;
    [Header("畫布 2048")]
    public Transform traCanvas2048;


    /// <summary>
    /// 所有區塊資料
    /// 因為資料太多，用類別包裝
    /// </summary>
    public BlockData[,] blocks = new BlockData[4, 4];
    private void Start()
    {
        Initialized();
    }
    /// <summary>
    /// 初始化資料
    /// </summary>
    private void Initialized()
    {
        for (int i = 0; i < blocks.GetLength(0); i++)
        {
            for (int j = 0; j < blocks.GetLength(1); j++)
            {
                blocks[i, j] = new BlockData(); // 類別資料需要新增實體資料，否則會有空值
                blocks[i, j].v2Index = new Vector2Int(i, j);
                blocks[i, j].v2Position = blockEmpty[i * blocks.GetLength(1) + j].position; // 物件的位子，內建為 .position
            }
        }
        PrintBlockData();
        CreateRandomNumber();
    }
    private void PrintBlockData()
    {
        string result = "";
        for (int i = 0; i < blocks.GetLength(0); i++)
        {
            for (int j = 0; j < blocks.GetLength(1); j++)
            {
                result += "編號" + blocks[i, j].v2Index + " <color=red>數字 : " + blocks[i,j].number + " </color>實際位置 : " + blocks[i,j].v2Position +" | ";
            }
            result += "\n";
        }
        print(result);  
    }

    /// <summary>
    /// 建立隨機數字區塊
    /// 判斷所有區塊內沒有數字的區塊 - 數字為零
    /// 隨機挑選一個生成數字放到該區塊內
    /// </summary>
    private void CreateRandomNumber()
    {
        var equalZero =
            from BlockData data in blocks
            where data.number == 0
            select data;
        print("為零的資料有幾筆 : " + equalZero.Count());

        int randomIndex = Random.Range(0, equalZero.Count());
        print("隨機編號 : " + randomIndex);

        // 選出隨機區塊 編號
        BlockData select = equalZero.ToArray()[randomIndex];
        BlockData dataRandom = blocks[select.v2Index.x, select.v2Index.y];
        // 將數字 2 輸入到隨機區塊內
        dataRandom.number = 2;

        PrintBlockData();

        // 實例化-生成(物件，父物件)
        GameObject  tempBlock = Instantiate(goNumberBlock, traCanvas2048);
    }
}
/// <summary>
/// 區塊資料
/// 每個區塊遊戲物件、座標、編號、數字
/// </summary>
public class BlockData
{
    public GameObject goBlock;  // 區塊內的數字物件
    public Vector2 v2Position;  // 區塊座標
    public Vector2Int v2Index;  // 區塊編號: 二維陣列的編號(整數)
    public int number;          // 區塊數字，預設為 0，或 2的倍數
}
