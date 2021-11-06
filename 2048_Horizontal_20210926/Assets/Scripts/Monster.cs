using UnityEngine;

public class Monster : MonoBehaviour    
{
    [Header("Monster 移動欄位"), Range(0, 10)]
    public float Monster_Move_Speed=3.5f ;
    [Range(0 ,500)]
    public float Monster_Att = 100;
    [Range(0, 5000)]
    public float Monster_Bload = 350;
    [Range(0, 50)]
    public float Monster_Move_Range = 30;
    public bool Vector_2D;

    [Header("掉落道具")]
    public bool GameObject;
    [Range(0, 10)]
    public int GameObject_Opportunity = 1;

    [Header("掉落道具音效")]
    public string Sound_GameObject;
    public string Sound_Monster_injure;
    public string Sound_Monster_Att;

    private string Sound_AudioSource;
    private string Sound_Rigidbody2D;
    private string Sound_Animator;
}
