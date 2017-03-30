using PureMVC.Patterns;
using SUIFW;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PureMVC.Interfaces;

/// <summary>
/// FileName: Vew_GamePlayingMediator.cs
/// Author: 
/// Description: 视图层 --》 游戏进行中UI界面显示控制
/// DateTime: 
/// </summary>
public class Vew_GamePlayingMediator : Mediator
{
    public new const string NAME = "Vew_GamePlayingMediator";

    //定义控件
    private Text _TxtGameTime;                          //游戏时间
    private Text _TxtShowGameTime;                  //显示游戏时间
    private Text _TxtGameScore;                         //游戏分数
    private Text _TxtShowGameScore;                 //显示游戏分数
    private Text _TxtGameHighestScore;              //游戏最高分数
    private Text _TxtShowGameHighestScore;      //显示游戏最高分数


    /// <summary>
    /// 构造函数
    /// </summary>
    public Vew_GamePlayingMediator() : base(NAME)
    {

    }

    /// <summary>
    /// 初始化字段
    /// </summary>
    private void InitMediatorFiled()
    {
        //得到层级视图根节点
        GameObject goRootCanvas = GameObject.Find("Canvas(Clone)");

        //得到文字控件
        _TxtGameTime = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "TxtTime");
        _TxtGameScore = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "TxtScores");
        _TxtGameHighestScore = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "TxtHighScores");
        _TxtGameTime.text = "时间";
        _TxtGameScore.text = "分数";
        _TxtGameHighestScore.text = "最高";

        //得到文字数值显示
        _TxtShowGameTime = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "TxtTimeShow");
        _TxtShowGameScore = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "TxtScoresShow");
        _TxtShowGameHighestScore = UnityHelper.GetTheChildNodeComponetScripts<Text>(goRootCanvas, "TxtHighScoresShow");
    }

    /// <summary>
    /// 允许可以接收的消息列表
    /// </summary>
    /// <returns></returns>
    public override IList<string> ListNotificationInterests()
    {
        IList<string> liResult = new List<string>();
        liResult.Add(ProjectConsts.Msg_DisplayGameInfo);
        liResult.Add(ProjectConsts.Msg_InitGamePlayingMediatorFiled);
        return liResult;
    }

    /// <summary>
    /// 处理接收到的消息列表
    /// </summary>
    /// <param name="notification"></param>
    public override void HandleNotification(INotification notification)
    {
        Model_GameData gameData = null;

        switch (notification.Name)
        {
            case ProjectConsts.Msg_DisplayGameInfo:
                gameData = notification.Body as Model_GameData;
                if (gameData != null)
                {
                    if (_TxtShowGameTime && _TxtShowGameScore && _TxtShowGameHighestScore)
                    {
                        _TxtShowGameTime.text = gameData.GameTime.ToString();
                        _TxtShowGameScore.text = gameData.Scores.ToString();
                        _TxtShowGameHighestScore.text = gameData.HightestScores.ToString();
                    }
                }
                break;

            case ProjectConsts.Msg_InitGamePlayingMediatorFiled:
                InitMediatorFiled();
                break;

            default:
                break;
        }
    }

}
