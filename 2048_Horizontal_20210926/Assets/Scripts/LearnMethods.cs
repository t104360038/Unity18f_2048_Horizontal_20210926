using UnityEditor.Build.Reporting;
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
        Drive(100,"������");
        Drive(200,"�F�F�F","���u");               //speed,sound
        Drive(30,effect: "���Y");       //speed,effect 
        // �ɼ� 30�A�S�ġA���Y
        // ���w�w�]�Ѽƻy�k�A�ѼƦW�� �_�� ��

        //Case A
        int t = Ten();
        print("�Ǧ^��k��:" + t);
        //Case B
        print("���ϥ��ܼ��x�s�Ǧ^��:" + Ten());
        int a=90,b =30;
        int damage = Damage(a,b);
        print("�ˮ`��"+ damage);
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

    // �w�q��k
    // �Ѽ� : ������� �ѼƦW�� (���w = �w�]��) �g�b()�̥k��
    // �h�Ѽ� 
    public void Drive(int speed,string sound = "������" ,string effect = "�ǹ�")
    {
        print("���t" + speed);
        print("����" + sound);
        print("�S��" + effect);
    }
    // ���Ǧ^������k�����ϥ� return   // Case A
    public int Ten()
    {
        return 10;
    }
    /// <summary>
    /// �p��ˮ`�ȡA�����O - ���m�O = �ˮ`��
    /// </summary>
    /// <param name="attack"></param>
    /// <param name="defence"></param>
    /// <returns>�ˮ`��</returns>
    public int Damage(int attack, int defence)
    {
        return attack - defence;
    }
}
