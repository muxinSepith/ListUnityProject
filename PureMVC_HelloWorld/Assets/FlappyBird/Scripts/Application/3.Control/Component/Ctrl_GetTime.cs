using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FileName: Ctrl_GetTime.cs
/// Author: 
/// Description: 控制层 --》 得到时间
/// DateTime: 
/// </summary>
public class Ctrl_GetTime : MonoBehaviour
{
    //模型代理
    public Model_GameDataProxy dataProxy = null;
    //游戏是否开始
    private bool _IsStartGame = false;


    /// <summary>
    /// 游戏开始
    /// </summary>
    public void StartGame()
    {
        //得到模型层类的对象实例
        //dataProxy = Facade.Instance.RetrieveProxy(Model_GameDataProxy.NAME) as Model_GameDataProxy;

        _IsStartGame = true;
    }

    /// <summary>
    /// 游戏结束
    /// </summary>
    public void StopGame()
    {
        _IsStartGame = false;
    }


    void Start()
    {
        //得到模型层类的对象实例
        dataProxy = Facade.Instance.RetrieveProxy(Model_GameDataProxy.NAME) as Model_GameDataProxy;

        //启动协程，每隔一秒钟，往PureMVC发送一条消息
        StartCoroutine("GetTime");
    }

    /// <summary>
    /// 协程，得到时间
    /// </summary>
    /// <returns></returns>
    IEnumerator GetTime()
    {
        yield return new WaitForEndOfFrame();

        while (true)
        {
            yield return new WaitForSeconds(1f);
            if (dataProxy != null && _IsStartGame)
            {
                //调用（Mediator）模型层方法
                dataProxy.AddGameTime();
            }
        }
    }
}
