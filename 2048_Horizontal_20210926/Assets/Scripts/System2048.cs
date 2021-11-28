using UnityEngine;
using System.Linq;
/// <summary>
/// 2048 �t��
/// �x�s�C�Ӱ϶����
/// �޲z�H���ͦ�
/// �ưʱ���
/// �Ʀr�X�֧P�w
/// �C������P�w
/// </summary>
public class System2048 : MonoBehaviour
{
    [Header("�ťհ϶�")]
    public Transform[] blockEmpty;
    [Header("�Ʀr�϶�")]
    public GameObject goNumberBlock;
    [Header("�e�� 2048")]
    public Transform traCanvas2048;


    /// <summary>
    /// �Ҧ��϶����
    /// �]����ƤӦh�A�����O�]��
    /// </summary>
    public BlockData[,] blocks = new BlockData[4, 4];
    private void Start()
    {
        Initialized();
    }
    /// <summary>
    /// ��l�Ƹ��
    /// </summary>
    private void Initialized()
    {
        for (int i = 0; i < blocks.GetLength(0); i++)
        {
            for (int j = 0; j < blocks.GetLength(1); j++)
            {
                blocks[i, j] = new BlockData(); // ���O��ƻݭn�s�W�����ơA�_�h�|���ŭ�
                blocks[i, j].v2Index = new Vector2Int(i, j);
                blocks[i, j].v2Position = blockEmpty[i * blocks.GetLength(1) + j].position; // ���󪺦�l�A���ج� .position
            }
        }
        PrintBlockData();
        CreateRandomNumber();
    }
    private void PrintBlockData()
    {
        string result = "";
        for (int i = 0; i < blocks.GetLength(0); i++)
        {
            for (int j = 0; j < blocks.GetLength(1); j++)
            {
                result += "�s��" + blocks[i, j].v2Index + " <color=red>�Ʀr : " + blocks[i,j].number + " </color>��ڦ�m : " + blocks[i,j].v2Position +" | ";
            }
            result += "\n";
        }
        print(result);  
    }

    /// <summary>
    /// �إ��H���Ʀr�϶�
    /// �P�_�Ҧ��϶����S���Ʀr���϶� - �Ʀr���s
    /// �H���D��@�ӥͦ��Ʀr���Ӱ϶���
    /// </summary>
    private void CreateRandomNumber()
    {
        var equalZero =
            from BlockData data in blocks
            where data.number == 0
            select data;
        print("���s����Ʀ��X�� : " + equalZero.Count());

        int randomIndex = Random.Range(0, equalZero.Count());
        print("�H���s�� : " + randomIndex);

        // ��X�H���϶� �s��
        BlockData select = equalZero.ToArray()[randomIndex];
        BlockData dataRandom = blocks[select.v2Index.x, select.v2Index.y];
        // �N�Ʀr 2 ��J���H���϶���
        dataRandom.number = 2;

        PrintBlockData();

        // ��Ҥ�-�ͦ�(����A������)
        GameObject  tempBlock = Instantiate(goNumberBlock, traCanvas2048);
    }
}
/// <summary>
/// �϶����
/// �C�Ӱ϶��C������B�y�СB�s���B�Ʀr
/// </summary>
public class BlockData
{
    public GameObject goBlock;  // �϶������Ʀr����
    public Vector2 v2Position;  // �϶��y��
    public Vector2Int v2Index;  // �϶��s��: �G���}�C���s��(���)
    public int number;          // �϶��Ʀr�A�w�]�� 0�A�� 2������
}
