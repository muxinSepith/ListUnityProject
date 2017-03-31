using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FileName: Ctrl_Pipe.cs
/// Author: 
/// Description: 控制层 --》 管道控制脚本  单个管道碰撞检测
/// DateTime: 
/// </summary>
[RequireComponent(typeof(BoxCollider2D))]
public class Ctrl_PipeAndLand : MonoBehaviour
{

    /// <summary>
    /// 2D碰撞检测
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //普通PureMVC的通知，游戏结束
            Facade.Instance.SendNotification(ProjectConsts.Reg_EndGameCommond);
        }
    }

}
