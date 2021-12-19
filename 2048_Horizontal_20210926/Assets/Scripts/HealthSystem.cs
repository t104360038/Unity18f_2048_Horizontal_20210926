using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


/// <summary>
/// ��q�t��
/// �޲z��q�A���˻P���`
/// </summary>
public class HealthSystem : MonoBehaviour
{
    [Header("��q"), Range(0, 500)]
    public float hp = 100;
    [Header("�n�����q���")]
    public Text textHp;
    public Image imgHp;
    [Header("�y���ˮ`���������")]
    public string tageDamageObject;
    [Header("�ʵe�Ѽ�")]                        //p21.10
    public string parameterDamage = "����Ĳ�o";
    public string parameterDead = "���`Ĳ�o";
    [Header("���`�ƥ�")]
    public UnityEvent onDead;

    private float hpMax;
    private Animator ani;                       //p21.10

    // ����ƥ�F�bStar ���e����@���A�B�z��l��
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

    // �I���O�ƥ�: ��ӸI�����䤤�@�Ӧ��Ŀ� IS Trigger
    // Enter �I���}�l�ɰ��榹�ƥ�@��
    // collision �I�쪫�󪺸I����T
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == tageDamageObject)
        {
            // ����(�y���ˮ`���� �l�u�t�� �� �����O)    //p22.03
            Hurt(collision.GetComponent<Bullet>().attack);

        }
    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="damage">�����쪺�ˮ`</param>
    public void Hurt(float damage)
    {
        if (hp <= 0) return;                //p22.01 �p�G���`�N���X
        hp -= damage;
        hp = Mathf.Clamp(hp, 0, hpMax);     //p22.01 ����(hp, �̤p�A�̤j)
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
