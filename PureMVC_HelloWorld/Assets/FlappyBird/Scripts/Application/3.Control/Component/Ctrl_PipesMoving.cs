using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FileName: Ctrl_PipesMoving.cs
/// Author: 
/// Description: 控制层 --》 管道组移动脚本
/// DateTime: 
/// </summary>
public class Ctrl_PipesMoving : MonoBehaviour
{

    public float floMovingSpeed = 2f;               //管道移动速度
    private Vector2 _VecOriginalPosition;          //管道原始位置
    private bool _IsStartGame = false;


    //游戏开始
    public void StartGame()
    {
        _IsStartGame = true;
    }

    //游戏结束
    public void StopGame()
    {
        _IsStartGame = false;

        //管道复位
        transform.position = _VecOriginalPosition;
    }



    void Start()
    {
        //保存陆地原始位置
        _VecOriginalPosition = transform.position;
    }

    void Update()
    {
        if (!_IsStartGame) return;

        //陆地循环移动，到了临界值，恢复原始方位
        if (transform.position.x < -20f)
        {
            transform.position = _VecOriginalPosition;
        }

        //移动
        transform.Translate(Vector2.left * Time.deltaTime * floMovingSpeed);
    }



    /// <summary>
    /// 管道复位
    /// </summary>
    private void ResetPipesPosition()
    {
        transform.position = _VecOriginalPosition;
    }
}
