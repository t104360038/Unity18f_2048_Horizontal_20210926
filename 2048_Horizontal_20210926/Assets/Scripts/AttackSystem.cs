using UnityEngine;

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
    #endregion

    #region ��k : ���}
    //  virtual ���� : ���\�l���O�Ƽg
    public virtual void Attack()
    {
        print("�o�ʧ����A�����O��: " + attack);
    }
    #endregion
}
