
using UnityEngine;

public class Car : MonoBehaviour
{
    #region ���y�k�P�|�j������
    //��¦������O    ���int �B�I��float  �r��string    �r��Char  ���Lbool
    //����ݩ� Attritube
    //�y�k:
    // [�ݩʦW��(��)] - ������b���e���ΤW�@��
    //  1.  ���D  Header (�r��)
    //  2.  ����  Tooltrip (�r��)
    //  3.  �d��  Range   (float,float)��int
    [Header("�T�����U���ƭ�"),Range(1000,10000)]
    public int CC = 2000;
    [Tooltip("�o�O�T�������q�A�d��O3~10�y")][Range(3,10)]
    public float weight = 3.5f;
    public string brand = "���h";
    public char CarDoor = '4';
    public bool haveSkyWindow = true;
    #endregion
    #region   �C�����`�θ������
    //  �C�� Color
    public Color colorRed = Color.red;
    public Color colorCustom = new Color(0, 0, 1);
    public Color colorCustomAlpga = new Color(0, 1, 0, 0.3f);
    public Color32 colorCustomAlpga255 = new Color(0, 255, 0, 0.3f);
    //  �V�q  Vector
    //  Vector  2 - 4
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Up = Vector2.up;
    public Vector3 v3Custom = new Vector3(7,9,3);
    public Vector4 v4Custom = new Vector4(7, 9, 3, 3.2f);
    //  ���� KeyCode
    public KeyCode kc;
    public KeyCode kcCustom = KeyCode.Mouse0;   

    //  �C������    GameObject
    public GameObject carbox;
    public GameObject carOil;

    //  ���� Component
    public Transform traBox;
    public SpriteRenderer sprBox;
    public Camera cam;
    #endregion
    #region �s������� Set Get
    //  �{���J�f:�ƥ�
    //  �}�l�ƥ�:����C���ɰ���@���A��l�]�w
    private void Start()
    {
        print("Hellow World !!");

        //  ���o����� *�w�]�Ȥw�ݩʭ��O���u�� (Inspector)
        //  �y�k:
        //  ���W��
        print("CC��"+CC);
        print(weight);

        // �]�w: Set

        CC = 3500;
        print("�]�w�|��CC��" + CC);
    }
    #endregion
}
