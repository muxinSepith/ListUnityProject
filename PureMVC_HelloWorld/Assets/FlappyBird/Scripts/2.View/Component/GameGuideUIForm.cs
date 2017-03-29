using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUIFW;

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
             OpenUIForm("GamePlayingUIForm")

            //MVC启动命令
            //todo...
            );
    }

}
