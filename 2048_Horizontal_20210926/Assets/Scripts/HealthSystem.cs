using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


/// <summary>
/// 血量系統
/// 管理血量，受傷與死亡
/// </summary>
public class HealthSystem : MonoBehaviour
{
    [Header("血量"), Range(0, 500)]
    public float hp = 100;
    [Header("要控制的血量血條")]
    public Text textHp;
    public Image imgHp;
    [Header("造成傷害的物件標籤")]
    public string tageDamageObject;
    [Header("動畫參數")]                        //p21.10
    public string parameterDamage = "受傷觸發";
    public string parameterDead = "死亡觸發";
    [Header("死亡事件")]
    public UnityEvent onDead;

    private float hpMax;
    private Animator ani;                       //p21.10

    // 喚醒事件；在Star 之前執行一次，處理初始值
    public void Awake()
    {
        hpMax = hp;
        ani = GetComponent<Animator>();         //p21.10
    }

    private void Start()                        //p22.02
    {
        textHp.text = "HP  " + hp;
        imgHp.fillAmount = 1;
    }

    // 碰撞是事件: 兩個碰撞器其中一個有勾選 IS Trigger
    // Enter 碰撞開始時執行此事件一次
    // collision 碰到物件的碰撞資訊
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == tageDamageObject)
        {
            // 受傷(造成傷害物件 子彈系統 的 攻擊力)    //p22.03
            Hurt(collision.GetComponent<Bullet>().attack);

        }
    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">接收到的傷害</param>
    public void Hurt(float damage)
    {
        if (hp <= 0) return;                //p22.01 如果死亡就跳出
        hp -= damage;
        hp = Mathf.Clamp(hp, 0, hpMax);     //p22.01 夾住(hp, 最小，最大)
        textHp.text = "HP " + hp;
        imgHp.fillAmount = hp / hpMax;
        ani.SetTrigger(parameterDamage);    //p21.10
        if (hp <= 0) Dead();                //p22.01
    }

    private void Dead()                     //p22.01
    {
        onDead.Invoke();
    }
}
