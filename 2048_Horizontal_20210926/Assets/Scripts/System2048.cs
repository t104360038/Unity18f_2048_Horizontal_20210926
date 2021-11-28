using UnityEngine;
using System.Linq;
using UnityEngine.UIElements;
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
    #region 欄位 : 公開
    [Header("空白區塊")]
    public Transform[] blockEmpty;
    [Header("數字區塊")]
    public GameObject goNumberBlock;
    [Header("畫布 2048")]
    public Transform traCanvas2048;
    #endregion

    #region 欄位 : 私人
    // 私人欄位顯示在屬性面板上
    [SerializeField]
    private Direction direction;
    /// <summary>
    /// 所有區塊資料
    /// 因為資料太多，用類別包裝
    /// </summary>
    public BlockData[,] blocks = new BlockData[4, 4];

    // p.17.03
    /// <summary>
    /// 按下座標
    /// </summary>
    private Vector3 posDown;
    /// <summary>
    /// 放開座標
    /// </summary>
    private Vector3 posUp;
    /// <summary>
    /// 是否按下左鍵
    /// </summary>
    private bool isClickMouse;
    #endregion

    #region 事件
    private void Start()
    {
        Initialized();
    }
    #endregion

    private void Update()
    {
        CheckDirection();
    }
    #region 方法:私人
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
        CreateRandomNumber();
    }

    /// <summary>
    /// 輸出區塊二維陣列資料
    /// </summary>
    private void PrintBlockData()
    {
        string result = "";
        for (int i = 0; i < blocks.GetLength(0); i++)
        {
            for (int j = 0; j < blocks.GetLength(1); j++)
            {
                // 編號、數字與座標
                // result += "編號" + blocks[i, j].v2Index + " <color=red>數字 : " + blocks[i,j].number + " </color> <color=yellow>實際位置 : " + blocks[i,j].v2Position +"</color> | ";
                // 編號、數字與 --p.16.10
                // 三元運算子 --p.17.10
                // 語法 : 布林值 ? 值A : 值B ;
                // 當布林值為 true 結果為 值A
                // 當布林值為 false 結果為 值A
                result += "編號" + blocks[i, j].v2Index + " <color=red>數字 : " + blocks[i, j].number + " </color> <color=yellow>" + (blocks[i, j].goBlock ? "有" : "無") + "</color> | ";
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
     //   print("為零的資料有幾筆 : " + equalZero.Count());

        int randomIndex = Random.Range(0, equalZero.Count());
        print("隨機編號 : " + randomIndex);

        // 選出隨機區塊 編號
        BlockData select = equalZero.ToArray()[randomIndex];
        BlockData dataRandom = blocks[select.v2Index.x, select.v2Index.y];
        // 將數字 2 輸入到隨機區塊內
        dataRandom.number = 2;


        // 實例化-生成(物件，父物件) --p.16.09
        GameObject  tempBlock = Instantiate(goNumberBlock, traCanvas2048);
        // 生成區塊 指定座標
        tempBlock.transform.position = dataRandom.v2Position;
        // 儲存 生成區塊 資料
        dataRandom.goBlock = tempBlock;
        PrintBlockData();//p.17.10 搬家
    }
    
    /// <summary>
    /// 檢查方向
    /// p.17.01 
    /// </summary>
    private void CheckDirection() //p.17.02
    {
        #region 鍵盤
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Direction.Up;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Direction.Down;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Direction.Left;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Direction.Right;
            CheckAndMoveBlock();
        }
        #endregion

        #region 滑鼠與手機觸控
        if (!isClickMouse && Input.GetKeyDown(KeyCode.Mouse0))
        {
            isClickMouse = true;
            posDown = Input.mousePosition;
            //print("按下座標 : " + posDown);
        }
        else if (isClickMouse && Input.GetKeyUp(KeyCode.Mouse0))
        {
            isClickMouse = false;
            posUp = Input.mousePosition;
            //print("放開座標 : " + posUp);

            // p.17.05
            // 1. 計算向量值 放開座標 - 按下座標
            Vector3 directionValue = posUp - posDown;
            // 2. 轉換成 0 ~ 1 值 normalized
            //print("轉換數值 : " + directionValue.normalized);

            // 方向 X 與 Y 取絕對值 p.17.06
            float xAbs = Mathf.Abs(directionValue.normalized.x);
            float yAbs = Mathf.Abs(directionValue.normalized.y);
            // X > Y 水平方向
            if (xAbs > yAbs)
            {
                if (directionValue.x > 0) direction = Direction.Right;
                else direction = Direction.Left;
                CheckAndMoveBlock();

            }
            // X < Y 垂直方向
            else if (yAbs > xAbs)
            {
                if (directionValue.y > 0) direction = Direction.Up;
                else direction = Direction.Down;
                CheckAndMoveBlock();
            }
        }
        #endregion
    }
    /// <summary>
    /// 檢查並移動區塊
    /// </summary>
    private void CheckAndMoveBlock() //p.17.08~09
    {
        print("目前的方向: " + direction);

        switch (direction)
        {
            case Direction.None:
                break;
            case Direction.Up:
                break;
            case Direction.Down:
                break;
            case Direction.Left:
                // 檢查左邊有無數字  // p.18.01

                for (int i = 0; i < blocks.GetLength(0); i++)
                {
                    for (int j = 0; j < blocks.GetLength(1); j++)
                    {
                        //print("區塊的數字: " + blocks[i, j].number);

                        // 如果 該區域的數字 為零 就繼續 (跳過此迴圈執行下個迴圈)
                        if (blocks[i, j].number == 0) continue;
                        print("有數字的區塊: " + blocks[i, j].v2Index);
                    }
                }
                break;
            case Direction.Right:
                break;
            default:
                break;
        }
    }
    #endregion


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
/// <summary>
/// 方向列舉 : 無、上、下、左、右
/// </summary>
public enum Direction
{
    None, Up, Down, Left, Right
}