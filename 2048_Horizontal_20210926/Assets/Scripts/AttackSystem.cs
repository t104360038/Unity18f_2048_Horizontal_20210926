using UnityEngine;
using UnityEngine.UI;                                   //p22.04
using UnityEngine.Events;                               //p22.10
using System.Collections;  // �ޥ� �t�� ���X API: ��P�{�� Coroutione     //p22.09

/// <summary>
/// �����t��: ��Z��
/// </summary>
public class AttackSystem : MonoBehaviour
{
    #region ��� : ���}
    [Header("�����O��")]
    public float attack = 10;
    [Header("�����O�ؼ�")]
    public GameObject goTarget;
    [Header("�����O����")]                                   //p22.04
    public Text textAttack;
    [Header("�������"), Range(0, 10)]                       //p22.09
    public float delayAttack = 3.5f;
    [Header("����ǰe�ˮ`"), Range(0, 5)]                     //p22.08
    public float delaySendDamage = 0.5f;
    [Header("�ʵe�Ѽ�")]
    public string parameterAttack = "����Ĳ�o";               //p22.08
    #endregion

    #region �O�@ protected
    /// <summary>
    /// public      ���\�������O�s��                //p22.08
    /// pricate     ���\�l���O�s��
    /// protected   ���\�l���O�s��
    /// </summary>
    protected HealthSystem targetHealthSystem;
    protected Animator ani;
    #endregion

    #region �ƥ�
    private void Awake()
    {
        textAttack.text = "Atk  " + attack;
        ani = GetComponent<Animator>();                             //p22.08
        targetHealthSystem = goTarget.GetComponent<HealthSystem>(); //p22.08
    }
    #endregion

    [Header("�����}�l�ƥ�")]                          //p23.05
    public UnityEvent onAttackStart;
    [Header("���������ƥ�")]                          //p22.10
    public UnityEvent onAttackFinish;

    #region ��k : ���}
    //  virtual ���� : ���\�l���O�Ƽg
    /// <summary>
    /// ������k
    /// </summary>
    public virtual void Attack(float increase = 0)
    {
        // �Ұ� ��P�{��
        StartCoroutine(DelayAttack());              //p22.09

    }
    private IEnumerator DelayAttack()               //p22.09
    {
        // ���� 3.5 ��
        yield return new WaitForSeconds(delayAttack);
        // �����ʵe
        ani.SetTrigger(parameterAttack);            //p22.08
        // ���� 0.5 ��
        yield return new WaitForSeconds(delaySendDamage);
        
        onAttackStart.Invoke();                     //p23.05

        // �ǰe�ˮ`
        targetHealthSystem.Hurt(attack);
        onAttackFinish.Invoke();                    //p22.10
    }
    #endregion
    //[Header("�����}�l�ƥ�")]
    //public UnityEvent onAttackStart;
    //[Header("���������ƥ�")]
    //public UnityEvent onAttackFinish;
}
