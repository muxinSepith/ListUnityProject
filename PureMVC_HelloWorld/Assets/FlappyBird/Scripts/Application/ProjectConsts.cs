using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FileName: ProjectConsts.cs
/// Author: 
/// Description: 常量
/// DateTime: 
/// </summary>
public class ProjectConsts
{

    /* PureMVC 通信常量 */
    //命令通知
    public const string Reg_StartGameCommand = "Reg_StartGameCommand";
    public const string Reg_EndGameCommond = "Reg_EndGameCommond";
    
    //消息通知
    public const string Msg_DisplayGameInfo = "Msg_DisplayGameInfo";
    public const string Msg_InitGamePlayingMediatorFiled = "Msg_InitGamePlayingMediatorFiled";



    /* UI窗体预设名称 */
    public const string StartUIForm = "StartUIForm";
    public const string GameGuideUIForm = "GameGuideUIForm";
    public const string GamePlayingUIForm = "GamePlayingUIForm";



    /* PlayerPrefs */
    public const string GameHightestScores = "GameHightestScores";



    /* 其他常量 */
    public const string Player = "Player"; 
    public const string MainGameScenes = "MainGameScenes"; 
    public const string GamePipes = "GamePipes"; 
    public const string GameLanding = "GameLanding";
    public const string xxx = "xxx";


}
