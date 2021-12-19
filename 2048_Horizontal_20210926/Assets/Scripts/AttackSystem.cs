using UnityEngine;
using UnityEngine.UI;                                   //p22.04
using UnityEngine.Events;                               //p22.10
using System.Collections;  // 引用 系統 集合 API: 協同程序 Coroutione     //p22.09

/// <summary>
/// 攻擊系統: 近距離
/// </summary>
public class AttackSystem : MonoBehaviour
{
    #region 欄位 : 公開
    [Header("攻擊力基底")]
    public float attack = 10;
    [Header("攻擊力目標")]
    public GameObject goTarget;
    [Header("攻擊力介面")]                                   //p22.04
    public Text textAttack;
    [Header("延遲攻擊"), Range(0, 10)]                       //p22.09
    public float delayAttack = 3.5f;
    [Header("延遲傳送傷害"), Range(0, 5)]                     //p22.08
    public float delaySendDamage = 0.5f;
    [Header("動畫參數")]
    public string parameterAttack = "攻擊觸發";               //p22.08
    #endregion

    #region 保護 protected
    /// <summary>
    /// public      允許任何類別存取                //p22.08
    /// pricate     允許子類別存取
    /// protected   允許子類別存取
    /// </summary>
    protected HealthSystem targetHealthSystem;
    protected Animator ani;
    #endregion

    #region 事件
    private void Awake()
    {
        textAttack.text = "Atk  " + attack;
        ani = GetComponent<Animator>();                             //p22.08
        targetHealthSystem = goTarget.GetComponent<HealthSystem>(); //p22.08
    }
    #endregion

    [Header("攻擊開始事件")]                          //p23.05
    public UnityEvent onAttackStart;
    [Header("攻擊完成事件")]                          //p22.10
    public UnityEvent onAttackFinish;

    #region 方法 : 公開
    //  virtual 虛擬 : 允許子類別複寫
    /// <summary>
    /// 攻擊方法
    /// </summary>
    public virtual void Attack(float increase = 0)
    {
        // 啟動 協同程序
        StartCoroutine(DelayAttack());              //p22.09

    }
    private IEnumerator DelayAttack()               //p22.09
    {
        // 延遲 3.5 秒
        yield return new WaitForSeconds(delayAttack);
        // 攻擊動畫
        ani.SetTrigger(parameterAttack);            //p22.08
        // 延遲 0.5 秒
        yield return new WaitForSeconds(delaySendDamage);
        
        onAttackStart.Invoke();                     //p23.05

        // 傳送傷害
        targetHealthSystem.Hurt(attack);
        onAttackFinish.Invoke();                    //p22.10
    }
    #endregion
    //[Header("攻擊開始事件")]
    //public UnityEvent onAttackStart;
    //[Header("攻擊完成事件")]
    //public UnityEvent onAttackFinish;
}
