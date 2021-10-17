
using UnityEngine;

public class Car : MonoBehaviour
{
    #region 欄位語法與四大基本類型
    //基礎資料類別    整數int 浮點數float  字串string    字元Char  布林bool
    //欄位屬性 Attritube
    //語法:
    // [屬性名稱(值)] - 必須放在欄位前面或上一行
    //  1.  標題  Header (字串)
    //  2.  提示  Tooltrip (字串)
    //  3.  範圍  Range   (float,float)或int
    [Header("汽車的各項數值"),Range(1000,10000)]
    public int CC = 2000;
    [Tooltip("這是汽車的重量，範圍是3~10頓")][Range(3,10)]
    public float weight = 3.5f;
    public string brand = "賓士";
    public char CarDoor = '4';
    public bool haveSkyWindow = true;
    #endregion
    #region   遊戲內常用資料類型
    //  顏色 Color
    public Color colorRed = Color.red;
    public Color colorCustom = new Color(0, 0, 1);
    public Color colorCustomAlpga = new Color(0, 1, 0, 0.3f);
    public Color32 colorCustomAlpga255 = new Color(0, 255, 0, 0.3f);
    //  向量  Vector
    //  Vector  2 - 4
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Up = Vector2.up;
    public Vector3 v3Custom = new Vector3(7,9,3);
    public Vector4 v4Custom = new Vector4(7, 9, 3, 3.2f);
    //  按鍵 KeyCode
    public KeyCode kc;
    public KeyCode kcCustom = KeyCode.Mouse0;   

    //  遊戲物件    GameObject
    public GameObject carbox;
    public GameObject carOil;

    //  元件 Component
    public Transform traBox;
    public SpriteRenderer sprBox;
    public Camera cam;
    #endregion
    #region 存取欄位資料 Set Get
    //  程式入口:事件
    //  開始事件:播放遊戲時執行一次，初始設定
    private void Start()
    {
        print("Hellow World !!");

        //  取得欄位資料 *預設值已屬性面板為優先 (Inspector)
        //  語法:
        //  欄位名稱
        print("CC數"+CC);
        print(weight);

        // 設定: Set

        CC = 3500;
        print("設定會的CC數" + CC);
    }
    #endregion
}
