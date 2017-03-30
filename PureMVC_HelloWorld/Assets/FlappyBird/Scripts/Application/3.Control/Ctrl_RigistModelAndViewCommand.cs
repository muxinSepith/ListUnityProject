using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Interfaces;

/// <summary>
/// FileName: Ctrl_RigistModelAndViewCommand.cs
/// Author: 
/// Description: 命令层 --》 注册模型与视图层
/// DateTime: 
/// </summary>
public class Ctrl_RigistModelAndViewCommand : SimpleCommand
{

    public override void Execute(INotification notification)
    {
        Facade.RegisterProxy(new Model_GameDataProxy());
        Facade.RegisterMediator(new Vew_GamePlayingMediator());
    }

}
