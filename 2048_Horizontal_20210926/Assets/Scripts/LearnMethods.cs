using UnityEngine;

public class LearnMethods : MonoBehaviour
{
    // Methods ��k: Funetion (�禡)
    // �@��: ������������{�����e
    // �y�k:
    // �׹��� �Ǧ^������� ��k�W��(�Ѽ�){ �{�����e }
    // �L�Ǧ^ void
    // �R�W�ߺD: Unity ��k�H�j�g�}�Y
    // �ۭq��k: ���|����
    public void Test()
    {
        print("I'm Test Methods!");
    }
    private void Start()
    {
        //�I�s�覡: ��k�W��();
        Test();
        Drive150();
        Drive100();
        Drive(69);
        Drive(99);
    }

    // �����ݨD
    // ���񭵮�
    // �T���i�H�[�t�A�ɳt�� 90;
    // �T���i�H�[�t�A�ɳt�� 90;
    public void Drive150()
    {
        print("Car_Speed: " + 150);
        print("Sound!");
    }
    public void Drive100()
    {
        print("Car_Speed: " + 100);
        print("Sound!");
    }
    public void Drive(int speed)
    {
        print("Car_Speed" + speed);
        print("Sound!");
    }
}
