using UnityEngine;

/// <summary>
/// �����t��: ���Z��
/// �~�ӻy�k: �l���O : �n�~�Ӫ����O(�����O)
/// �֦������O������: ���B�ݩʡB��k�B�ƥ�
/// </summary>
public class AttackSystemFar : AttackSystem
{
    #region ��� : ���}
    [Header("�ͦ��ɤl��m")]
    public Transform positionSpawn;
    [Header("�����O�ɤl")]
    public GameObject goAttackParticle;
    [Header("�ɤl�o�g�t��"),Range(0,1500)]
    public float speed = 500;
    #endregion

    // overide �Ƽg : �Ƽg�����O virtual ����
    public override void Attack()
    {
        base.Attack();              // base ��: �����O�����e

        // �ͦ�(����A�y�СA����)�ͦ�������W�٫��|��(clone)       //p21.04
        //  
        //  Quaternion �|���ơA��������
        //  identity �s����
        GameObject tempAttack = Instantiate(goAttackParticle, positionSpawn.position, Quaternion.identity);
        tempAttack.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));           //p21.05

    }
} 
