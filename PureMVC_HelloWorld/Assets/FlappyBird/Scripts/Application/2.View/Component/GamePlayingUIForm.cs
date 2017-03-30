using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUIFW;

/// <summary>
/// FileName: GamePlayingUIForm.cs
/// Author: 
/// Description: 游戏进行中
/// DateTime: 
/// </summary>
public class GamePlayingUIForm : BaseUIForm
{
    private void Awake()
    {
        //UI窗体类型
        CurrentUIType.UIForms_ShowMode = UIFormShowMode.HideOther;

    }
}
