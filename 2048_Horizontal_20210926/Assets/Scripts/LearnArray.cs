using UnityEngine;

public class LearnArray : MonoBehaviour
{
    //  �������[] - �}�C�������
    //  �}�C: �x�s�ۦP�������
    public int[] scores;
    //  �w�q�@�ӥ]�t�ƶq���}�C
    public float[] attacks = new float[3];
    //  �w�q�]�t�Ȫ��}�C
    public string[] props = { "����", "�Ť�", "��" };

    private void Start()
    {
        //  �s���}�C���
        //  ���o�}�C���
        //  �y�k: �}�C�W��[�s��] - �s���q�s�}�l
        print("�ĤT�ӹD��: " + props[2]);
        //  print("�ĤT�ӹD��: " + props[3]);    //  OutOfRange  �W�X�d��
        //  �]�w�}�C���
        //  �y�k: �}�C�W��[�s��] ���w ��;
        props[0] = "����";

        //  �}�C�ƶq Length
        print("�D�㪺�ƶq: " + props.Length);

        //  �ۥΰj��]�w�}�C�ȣ�: 10 ~ 50
        for (int x = 0; x < scores.Length; x++)
        {
            scores[x] = x * 10 + 10;
        }
    }
    
}
