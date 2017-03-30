using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FileName: Ctrl_Golds.cs
/// Author: 
/// Description: 控制层 --》 金币触发检测
/// DateTime: 
/// </summary>
[RequireComponent(typeof(BoxCollider2D))]
public class Ctrl_Golds : MonoBehaviour
{
    //模型代理
    private Model_GameDataProxy _proxyObj;
    //是否开始
    private bool _IsStartGame = false;


    /// <summary>
    /// 开始游戏
    /// </summary>
    public void StartGame()
    {
        _proxyObj = Facade.Instance.RetrieveProxy(Model_GameDataProxy.NAME) as Model_GameDataProxy;

        _IsStartGame = true;
    }

    /// <summary>
    /// 结束游戏
    /// </summary>
    public void StopGame()
    {
        _IsStartGame = false;
    }

    void Start()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    /// <summary>
    /// 触发检测
    /// </summary>
    /// <param name="collision"></param>
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!_IsStartGame) return;

        if (collision.tag == ProjectConsts.Player)
        {
            _proxyObj.AddScores();
        }
    }

}
