using UnityEngine;

public class LearnIF : MonoBehaviour
{
    public bool OpenDoor;
    private void Start()
    {
        // �P�_�� if else
        // �y�k
        // �p�G (�P�_) {����{�����e}
        // �_�h { ���L�� ���� false �|���� �{�����e}
        if (true)
        {
            print("���L�� true");
        }

        // opendoor == true �P OpenDoor
        if (OpenDoor)
        {
            print("�}��");
        }
        else
        {
            print("����");
        }
    }
}
