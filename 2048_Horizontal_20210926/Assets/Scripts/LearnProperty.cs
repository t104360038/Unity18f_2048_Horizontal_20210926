using UnityEngine;

public class LearnProperty : MonoBehaviour
{
    // ���
    public int passwordField = 123456789;

    // �ݩ� Property
    // �y�k:   �׹���  ������� �ݩʦW�� {�s���l}
    // �۰ʹ�@
    public int  passwordProperty { get; set; }

    // �ϥ�²�g�Ϊk 
    // => �H�ڹF Lambda C# 6.0
    public int mypasswordProperty { get => 999; }  //�߿W�ݩ� �u����o

    // �߿W����g�k
    public string nameCharacter
    {
        get
        {
            print("�ڦb�ݩ� name Character �̭�~");
            return "Ben";
        }
    }
    // �߼g����g�k
    // set  �ϥ�����r value ��J��
    public float attack
    {
        set
        {
            print("�����O:" + value);
        }
    }

    //�}�l�ƥ�: ����ɰ���@��
    private void Start()
    {
        //�s�� Set �ݩʸ��
        //�y�k:
        //�ݩʦW�� ���w ��;
        passwordProperty = 777;
        //���o Get �ݩʸ��
        //�y�k:
        //�ݩʦW��
        print("�ݩʦW��:" + passwordProperty);

        //mypasswordProperty = 666;   //����]�w �߿W�ݩ�
        print("�ڪ��ݩʱK�X:" + nameCharacter);

        // print(attack);
        attack = 99.9f;
    }
}
