using UnityEngine;

/// <summary>
/// 攻擊系統: 遠距離
/// 繼承語法: 子類別 : 要繼承的類別(父類別)
/// 擁有父類別的成員: 欄位、屬性、方法、事件
/// </summary>
public class AttackSystemFar : AttackSystem
{
    #region 欄位 : 公開
    [Header("生成粒子位置")]
    public Transform positionSpawn;
    [Header("攻擊力粒子")]
    public GameObject goAttackParticle;
    [Header("粒子發射速度"),Range(0,1500)]
    public float speed = 500;
    #endregion

    // overide 複寫 : 複寫複類別 virtual 成員
    public override void Attack(float increase = 0)             //p23.08
    {
        //base.Attack();              // base 基底: 複類別的內容

        onAttackStart.Invoke();                                 //p23.05

        // 生成(物件，座標，角度)生成的物件名稱後方會有(clone)       //p21.04
        //  生成的物件名稱後方會有 (Clone)
        //  Quaternion 四元數，紀錄角度
        //  identity 零角度
        GameObject tempAttack = Instantiate(goAttackParticle, positionSpawn.position, Quaternion.identity);
        tempAttack.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));           //p21.05
        // 添加元件<子彈系統>().攻擊力 = 此攻擊系統攻擊力              //p22.03
        tempAttack.AddComponent<Bullet>().attack = attack + increase;//p23.08

        print("本次攻擊力: " + (attack + increase));
    }
} 
