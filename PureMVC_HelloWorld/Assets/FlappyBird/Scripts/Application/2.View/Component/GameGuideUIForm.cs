using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUIFW;
using PureMVC.Patterns;

/// <summary>
/// FileName: GameGuideUIForm.cs
/// Author: 
/// Description: 游戏玩法介绍
/// DateTime: 
/// </summary>
public class GameGuideUIForm : BaseUIForm
{

    private void Awake()
    {
        //本窗体类型
        CurrentUIType.UIForms_ShowMode = UIFormShowMode.HideOther;

        //注册按钮事件
        RigisterButtonObjectEvent("BtnGuideOK", p =>
        {
            OpenUIForm(ProjectConsts.GamePlayingUIForm);

            //MVC启动命令
            Facade.Instance.SendNotification(ProjectConsts.Reg_StartGameCommand);
            //对视图层字段初始化
            Facade.Instance.SendNotification(ProjectConsts.Msg_InitGamePlayingMediatorFiled);
        }
        );
    }

}
