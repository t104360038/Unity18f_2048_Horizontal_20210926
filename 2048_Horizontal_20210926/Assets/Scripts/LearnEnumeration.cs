using UnityEngine;

/// <summary>
/// �C�|: �U�Ԧ����
/// </summary>
public class LearnEnumeration : MonoBehaviour
{
    //  1. �w�q�C�|
    //  �y�k: �׹��� �C�| �C�|�W�� { �C�|1, �C�|2 �C�|3....}
    public enum StateEnum
    {
        Idle, Walk, Attack, Dead
    }
    //  2. �ϥΦC�|
    //  �y�k: �׹��� �C�|�W�� ���W�� ���w ��;
    public StateEnum state = StateEnum.Walk;

    private void Update()
    {
        switch (state)
        {
            case StateEnum.Idle:
                print("����");
                break;
            case StateEnum.Walk:
                print("����");
                break;
            case StateEnum.Attack:
                print("����");
                break;
            case StateEnum.Dead:
                print("���`");
                break;
            default:
                break;
        }
    }
}
