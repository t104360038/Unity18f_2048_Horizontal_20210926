using UnityEngine;
using System.Linq;
using UnityEngine.UIElements;
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
    #region ��� : ���}
    [Header("�ťհ϶�")]
    public Transform[] blockEmpty;
    [Header("�Ʀr�϶�")]
    public GameObject goNumberBlock;
    [Header("�e�� 2048")]
    public Transform traCanvas2048;
    #endregion

    #region ��� : �p�H
    // �p�H�����ܦb�ݩʭ��O�W
    [SerializeField]
    private Direction direction;
    /// <summary>
    /// �Ҧ��϶����
    /// �]����ƤӦh�A�����O�]��
    /// </summary>
    public BlockData[,] blocks = new BlockData[4, 4];

    // p.17.03
    /// <summary>
    /// ���U�y��
    /// </summary>
    private Vector3 posDown;
    /// <summary>
    /// ��}�y��
    /// </summary>
    private Vector3 posUp;
    /// <summary>
    /// �O�_���U����
    /// </summary>
    private bool isClickMouse;
    #endregion

    #region �ƥ�
    private void Start()
    {
        Initialized();
    }
    #endregion

    private void Update()
    {
        CheckDirection();
    }
    #region ��k:�p�H
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
        CreateRandomNumber();
    }

    /// <summary>
    /// ��X�϶��G���}�C���
    /// </summary>
    private void PrintBlockData()
    {
        string result = "";
        for (int i = 0; i < blocks.GetLength(0); i++)
        {
            for (int j = 0; j < blocks.GetLength(1); j++)
            {
                // �s���B�Ʀr�P�y��
                // result += "�s��" + blocks[i, j].v2Index + " <color=red>�Ʀr : " + blocks[i,j].number + " </color> <color=yellow>��ڦ�m : " + blocks[i,j].v2Position +"</color> | ";
                // �s���B�Ʀr�P --p.16.10
                // �T���B��l --p.17.10
                // �y�k : ���L�� ? ��A : ��B ;
                // ���L�Ȭ� true ���G�� ��A
                // ���L�Ȭ� false ���G�� ��A
                result += "�s��" + blocks[i, j].v2Index + " <color=red>�Ʀr : " + blocks[i, j].number + " </color> <color=yellow>" + (blocks[i, j].goBlock ? "��" : "�L") + "</color> | ";
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
     //   print("���s����Ʀ��X�� : " + equalZero.Count());

        int randomIndex = Random.Range(0, equalZero.Count());
        print("�H���s�� : " + randomIndex);

        // ��X�H���϶� �s��
        BlockData select = equalZero.ToArray()[randomIndex];
        BlockData dataRandom = blocks[select.v2Index.x, select.v2Index.y];
        // �N�Ʀr 2 ��J���H���϶���
        dataRandom.number = 2;


        // ��Ҥ�-�ͦ�(����A������) --p.16.09
        GameObject  tempBlock = Instantiate(goNumberBlock, traCanvas2048);
        // �ͦ��϶� ���w�y��
        tempBlock.transform.position = dataRandom.v2Position;
        // �x�s �ͦ��϶� ���
        dataRandom.goBlock = tempBlock;
        PrintBlockData();//p.17.10 �h�a
    }
    
    /// <summary>
    /// �ˬd��V
    /// p.17.01 
    /// </summary>
    private void CheckDirection() //p.17.02
    {
        #region ��L
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Direction.Up;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Direction.Down;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Direction.Left;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Direction.Right;
            CheckAndMoveBlock();
        }
        #endregion

        #region �ƹ��P���Ĳ��
        if (!isClickMouse && Input.GetKeyDown(KeyCode.Mouse0))
        {
            isClickMouse = true;
            posDown = Input.mousePosition;
            //print("���U�y�� : " + posDown);
        }
        else if (isClickMouse && Input.GetKeyUp(KeyCode.Mouse0))
        {
            isClickMouse = false;
            posUp = Input.mousePosition;
            //print("��}�y�� : " + posUp);

            // p.17.05
            // 1. �p��V�q�� ��}�y�� - ���U�y��
            Vector3 directionValue = posUp - posDown;
            // 2. �ഫ�� 0 ~ 1 �� normalized
            //print("�ഫ�ƭ� : " + directionValue.normalized);

            // ��V X �P Y ������� p.17.06
            float xAbs = Mathf.Abs(directionValue.normalized.x);
            float yAbs = Mathf.Abs(directionValue.normalized.y);
            // X > Y ������V
            if (xAbs > yAbs)
            {
                if (directionValue.x > 0) direction = Direction.Right;
                else direction = Direction.Left;
                CheckAndMoveBlock();

            }
            // X < Y ������V
            else if (yAbs > xAbs)
            {
                if (directionValue.y > 0) direction = Direction.Up;
                else direction = Direction.Down;
                CheckAndMoveBlock();
            }
        }
        #endregion
    }
    /// <summary>
    /// �ˬd�ò��ʰ϶�
    /// </summary>
    private void CheckAndMoveBlock() //p.17.08~09
    {
        print("�ثe����V: " + direction);

        switch (direction)
        {
            case Direction.None:
                break;
            case Direction.Up:
                break;
            case Direction.Down:
                break;
            case Direction.Left:
                // �ˬd���䦳�L�Ʀr  // p.18.01

                for (int i = 0; i < blocks.GetLength(0); i++)
                {
                    for (int j = 0; j < blocks.GetLength(1); j++)
                    {
                        //print("�϶����Ʀr: " + blocks[i, j].number);

                        // �p�G �Ӱϰ쪺�Ʀr ���s �N�~�� (���L���j�����U�Ӱj��)
                        if (blocks[i, j].number == 0) continue;
                        print("���Ʀr���϶�: " + blocks[i, j].v2Index);
                    }
                }
                break;
            case Direction.Right:
                break;
            default:
                break;
        }
    }
    #endregion


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
/// <summary>
/// ��V�C�| : �L�B�W�B�U�B���B�k
/// </summary>
public enum Direction
{
    None, Up, Down, Left, Right
}