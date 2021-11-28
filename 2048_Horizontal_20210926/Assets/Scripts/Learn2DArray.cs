using UnityEngine;
using System.Linq; // LinQ Query �d�߻y�� �A��Ƭd��

/// <summary>
/// �{�ѤG���}�C
/// </summary>
public class Learn2DArray : MonoBehaviour
{
    // �@���}�C
    public int[] numbers = { 1,3,5,7,9 };
    // �G���}�C
    public int[,] block = { { 00,01,30 }, {10,11,12 }, { 20,21,22 } , { 30,31,32 }};

    public string[,] objects = new string[2, 4];

    private void Start()
    {
        #region �s��
        
        // �@���}�C�s��
        numbers[0] = 4;
        print("�@���}�C�Ĥ������ : "+ numbers[4]);

        // �G���}�C�s��
        print("�@���}�C�ĤG�C�Ĥ@�� 1, 0 :" + block[1,0]);

        // �������  �@��  Length
        //          �G�����Ĥ@��  GetLength(0)
        //          �G�����ĤG��  GetLength(1)
        print("�@���}�C���ת��� : " + numbers.Length);
        print("�G���}�C�Ĥ@������ : " + block.GetLength(0) );
        print("�G���}�C�ĤG������ : " + block.GetLength(1) );

        string result = "";

        for (int i = 0; i < block.GetLength(0); i++)
        {
            for (int j = 0; j < block.GetLength(1); j++)
            {
                result += block[i, j] + "|";
            }
            result += "\n";
        }
        print("result : \n" + result);
        #endregion
        #region ��Ʒj�M


        // �j�M numbers �@���}�C���j�󵥩� 10 �����
        // var �L������ƫ��A
        // from ���A in �}�C�W��     - �q�}�C�j�M��ƨëO�s�� ���A
        // where ���A ����          - �P�_ ���A �O�_�ŦX����
        // selecr ���A;             - ��� �ŦX���� ���A
        var numberGratgerTen = //���X
            from int n in numbers
            where n >= 10
            select n;

        print("�ŦX >= 10 ��Ʀ��X��: " + numberGratgerTen.Count());
        for (int i = 0; i < numberGratgerTen.Count(); i++)
        {
            print(">= 10 ����Ƭ�: " + numberGratgerTen.ToArray()[i]);
        }
        #endregion

        // scores ���ή檺���Ʀ�����
        var noPass =
            from int no in block
            where no < 11
            select no;
        for (int i = 0; i < noPass.Count(); i++)
        {
            print("���ή檺���� " + noPass.ToArray()[i]);
        }
    }
}
