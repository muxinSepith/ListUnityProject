using PureMVC.Interfaces;
using PureMVC.Patterns;
using SUIFW;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FileName: Ctrl_EndGameCommond.cs
/// Author: 
/// Description: 命令层 --》 停止游戏
/// DateTime: 
/// </summary>
public class Ctrl_EndGameCommond : SimpleCommand
{

    public override void Execute(INotification notification)
    {
        //停止脚本运行
        StopScriptRuning();

        //关闭当前UI窗体，回到"玩家指导"UI窗体
        CloseCurrentUIForm();

        //保存当前最高分数
        SaveScore();
    }

    /// <summary>
    /// 停止脚本运行
    /// </summary>
    private void StopScriptRuning()
    {
        //主角停止运行
        GameObject.FindGameObjectWithTag("Player").GetComponent<Ctrl_HeroControl>().StopGame();

        //得到层级视图根结点
        GameObject goEnviromentRoot = GameObject.Find("MainGameScenes");

        //管道组复位
        UnityHelper.GetTheChildNodeComponetScripts<Ctrl_PipesMoving>(goEnviromentRoot, "GamePipes").StopGame();

        //获取时间脚本停止运行
        goEnviromentRoot.GetComponent<Ctrl_GetTime>().StopGame();

        //金币道具停止
        for (int i = 1; i <= 3; i++)
        {
            UnityHelper.GetTheChildNodeComponetScripts<Ctrl_Golds>(goEnviromentRoot, "Pipe" + i + "_Trigger").StopGame();
        }
    }

    private void CloseCurrentUIForm()
    {
        UIManager.GetInstance().CloseUIForms("GamePlayingUIForm");
    }

    private void SaveScore()
    {
        Model_GameDataProxy gameData = Facade.RetrieveProxy(Model_GameDataProxy.NAME) as Model_GameDataProxy;
        gameData.SaveHightestScores();

        //重置游戏时间
        gameData.ResetGameTime();
    }

}
