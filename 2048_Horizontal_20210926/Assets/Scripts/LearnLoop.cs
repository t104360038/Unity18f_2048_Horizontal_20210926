using UnityEngine;

public class LearnLoop : MonoBehaviour
{
    public int number= 0;
    public int numberEnd = 5;

    public int Count = 0;
    public int CountEnd = 10;
    void Start()
    {
        //  �j��: ���ư���
        //  while �j��y�k:
        //  while (���L��) { ���L�ȵ��� true �|���� ����쥬�L�Ȭ� faulse �{�����e }
        while (number < numberEnd +1)
        {   
            print("while �j��Ʀr: " + number );
            number++;
        }

        //  for (��l��; ���L��; �j�鵲������{���ԭz)
        for (int x = Count; x < CountEnd +1; x++)    //�ֳt�ܼ� ��x�� tab
        {
            print("For �j��Ʀr: " + x);
        }
    }

}
