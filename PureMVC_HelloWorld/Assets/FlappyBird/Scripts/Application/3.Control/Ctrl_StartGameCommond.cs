using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FileName: Ctrl_StartGameCommond.cs
/// Author: 
/// Description: 命令层（控制层） --》 开始游戏
/// DateTime: 
/// </summary>
public class Ctrl_StartGameCommond : MacroCommand//复合型Command：AddSubCommand可以自动执行相应命令类的Execute方法
{
    protected override void InitializeMacroCommand()
    {
        //注册模型和视图Command
        AddSubCommand(typeof(Ctrl_RigistModelAndViewCommand));

        //注册重新开始Command
        AddSubCommand(typeof(Ctrl_ReStartGameCommond));
    }
}
