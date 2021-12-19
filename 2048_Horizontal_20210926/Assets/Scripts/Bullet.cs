using UnityEngine;

/// <summary>
/// 子彈系統
/// 攜帶發射者的攻擊力
/// 處理碰撞後刪除物件
/// </summary>
public class Bullet : MonoBehaviour
{
    /// <summary>
    /// 發射者的攻擊力
    /// </summary>
    public float attack;                    //p22.02

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // gameObject 指此腳本的遊戲物件     //p22.02
        // Destroy()  刪除物件
        Destroy(gameObject);
    }
}
