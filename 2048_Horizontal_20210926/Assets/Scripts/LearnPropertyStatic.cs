using UnityEngine;

public class LearnPropertyStatic : MonoBehaviour
{
    public float Random_No ;
    public float Random_Mutiple;
    public int Card_no;
    public int[] Card_Type = new int[4];

    private void Start()
    {
    //    Random_No = Random.value;
        //  �R�A�ݩ� Static Property
        //  ���o�R�A�ݩ�
        //  �y�k:���O�W��.�R�A�ݩʦW��
    //    print("�H����: " + Random_No);

        //  �]�w�R�A�ݩ�
    //    print("������v���ƶq: " + Camera.allCamerasCount);

        //  Cursor.visible = false;
        //  print("Floor(�L����R��): " + Mathf.Floor(Random_No));
        //  print("Round(�|�ˤ��J): " + Mathf.Round(Random_No));

        for (int i = 0; i < Card_no; i++)
        {
            Random_Mutiple = Random.value;

            //  ��d 0.01=SSR 0.09=SR 0.30=R 0.60=N
            switch (Random_Mutiple)
            {
                case float Random_Mutiple when (Random_Mutiple <= 0.01):
                    print("���ߩ��SSR !");
                    Card_Type[0]++;
                    break;
                case float Random_Mutiple when (Random_Mutiple > 0.01 && Random_Mutiple <= 0.1):
                    print("���ߩ��SR !");
                    Card_Type[1]++;
                    break;
                case float Random_Mutiple when (Random_Mutiple > 0.1 && Random_Mutiple <= 0.4):
                    print("���R !");
                    Card_Type[2]++;
                    break;
                case float Random_Mutiple when (Random_Mutiple > 0.4 && Random_Mutiple <= 1):
                    print("���N ");
                    Card_Type[3]++;
                    break;
            }
        }
        print("SSR �@" + Card_Type[0] +"�i" + "SR �@" + Card_Type[1] + "�i" + "R �@" + Card_Type[2] + "�i" + "N �@" + Card_Type[3] + "�i");
    }
}