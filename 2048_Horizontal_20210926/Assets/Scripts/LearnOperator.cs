using UnityEngine;

/// <summary>
/// �{�ѹB��l
/// 1.���w
/// 2.�ƾ�
/// 3.���
/// 4.�޿�
/// </summary>

public class LearnOperator : MonoBehaviour
{

    public float a = 10;
    public float b = 3;
    public int c = 30;
    public int d = 100;


    private void Start()
    {
        #region ���w�B��l
        // ���w =
        // ��������w�B��l�k���A���w�ȵ�����
        #endregion
        #region �ƾǹB��l
        // �[����l
        // + - * / %
        print("���l��:" + (a % b));    // ���G��1
        #endregion
        #region ����B��l
        // �j�� �p�� �j���� �p���� ���� ������
        // >    <   >=      <=    ==    !=
        // �����ӭȡA�åB�o�쥬�L�ȵ��G
        print("a > b"+ (a > b)); //True
        print("a >= b" + (a >= b)); //True
        #endregion
        #region �޿�B��l
        // �åB�A�Ϊ̡A�A��
        // && �A || �A !
        // �åB�A�Ϊ�
        // �����ӥ��L�ȡA�åB�o�쥬�L�ȵ��G
        // �åB&& : ��0��0 --�u�n���@�� F ���G�N�O F
        print("t && t" + (true && true));        // t
        print("f && t" + (false && true));       // f
        print("t && f" + (true && false));       // f
        print("f && f" + (false && false));      // f
        // �Ϊ�|| : ��1��1 --�u�n���@�� T ���G�N�O T
        print("t || t" + (true || true));        // t
        print("f || t" + (false || true));       // t
        print("t || f" + (true || false));       // t
        print("f || f" + (false || false));      // f
        // Alt + shift + > �ֳt���----------------------------------
        // �A��: �u��[�b���L�ȫe��
        print(!true);                           // F
        print(!(false && true));                // T
        #endregion
    }


}
