using UnityEngine;

/// <summary>
/// �l�u�t��
/// ��a�o�g�̪������O
/// �B�z�I����R������
/// </summary>
public class Bullet : MonoBehaviour
{
    /// <summary>
    /// �o�g�̪������O
    /// </summary>
    public float attack;                    //p22.02

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // gameObject �����}�����C������     //p22.02
        // Destroy()  �R������
        Destroy(gameObject);
    }
}
