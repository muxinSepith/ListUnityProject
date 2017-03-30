using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Interfaces;
using SUIFW;

/// <summary>
/// FileName: Ctrl_ReStartGameCommond.cs
/// Author: 
/// Description: 
/// DateTime: 
/// </summary>
public class Ctrl_ReStartGameCommond : SimpleCommand
{

    public override void Execute(INotification notification)
    {
        //主角重新运行
        GameObject.FindGameObjectWithTag(ProjectConsts.Player).GetComponent<Ctrl_HeroControl>().StartGame();

        //得到层级视图根结点
        GameObject goEnviromentRoot = GameObject.Find(ProjectConsts.MainGameScenes);

        //管道组运行
        UnityHelper.GetTheChildNodeComponetScripts<Ctrl_PipesMoving>(goEnviromentRoot, ProjectConsts.GamePipes).StartGame();

        //获取时间脚本
        goEnviromentRoot.GetComponent<Ctrl_GetTime>().StartGame();

        //金币道具启动
        for (int i = 1; i <= 3; i++)
        {
            //道具开始运行
            UnityHelper.GetTheChildNodeComponetScripts<Ctrl_Golds>(goEnviromentRoot, "Pipe" + i + "_Trigger").StartGame();
        }
    }

}
