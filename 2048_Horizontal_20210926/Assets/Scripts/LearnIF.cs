using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class LearnIF : MonoBehaviour
{
    public bool OpenDoor;
    public int score = 99;

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
    public void Update()
    {
        //�p�G���� >= 60 �� �ή�
        if (score >= 60)
        {
            print("�ή�");
        }
        // �p�G���� >= 40 �ɦ�
        //�y�k: else if (���L��) {���L�� ��true �ɰ���}
        // else if ��b if �U��P else �W�� �A�i�H�L�u��
        else if (score >= 40)
        {
            print("�ɦ�");
        }
        // �p�G���� < 40�� ����
        else
        {
            print("����");
        }
    }

}
