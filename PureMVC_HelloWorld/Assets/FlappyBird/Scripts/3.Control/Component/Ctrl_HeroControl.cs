using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ctrl_HeroControl : MonoBehaviour
{

    //升力
    public float floUpPower = 3f;
    //2D刚体
    private Rigidbody2D rd2D;
    //主角原始位置
    private Vector2 _VecHeroOriginalPostion;
    //游戏是否开始
    private bool _IsGameStart = false;



    //游戏开始
    public void StartGame()
    {
        _IsGameStart = true;

        //启用2D刚体
        EnableRigibody2D();
    }

    //游戏结束
    public void StopGame()
    {
        _IsGameStart = false;

        //恢复小鸟的原始方位
        transform.position = _VecHeroOriginalPostion;

        //禁用2D刚体
        DisableRigibody2D();
    }


    private void Start()
    {
        //保存原始位置
        _VecHeroOriginalPostion = transform.position;
        //获取2D刚体
        rd2D = GetComponent<Rigidbody2D>();
        //禁用2D刚体
        DisableRigibody2D();

        StartGame();
    }

    /// <summary>
    /// 接收玩家的输入
    /// </summary>
    private void Update()
    {
        if (_IsGameStart)
        {
            if (Input.GetButton("Fire1"))
            {
                rd2D.velocity = Vector2.up * floUpPower;
            }
        }
    }



    private void EnableRigibody2D()
    {
        GetComponent<Rigidbody2D>().isKinematic = false;
    }

    private void DisableRigibody2D()
    {
        GetComponent<Rigidbody2D>().isKinematic = true;
    }
}
