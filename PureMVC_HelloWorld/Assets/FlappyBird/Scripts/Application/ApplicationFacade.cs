using PureMVC.Patterns;
using SUIFW;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FileName: ApplicationFacade.cs
/// Author: 
/// Description: 启动PureMVC框架
/// DateTime: 
/// </summary>
public class ApplicationFacade : Facade
{

    public ApplicationFacade()
    {
        //注册核心的"命令"
        //RegisterCommand(ProjectConsts.Reg_StartGameCommand, typeof(Ctrl_StartGameCommond));
        RegisterCommand(ProjectConsts.Reg_StartGameCommand, typeof(Ctrl_ReStartGameCommond));
        RegisterCommand(ProjectConsts.Reg_EndGameCommond, typeof(Ctrl_EndGameCommond));

        //注册"模型层"与"视图层"
        RegisterProxy(new Model_GameDataProxy());
        RegisterMediator(new Vew_GamePlayingMediator());

        //添加游戏对象脚本
        AddGameObjectScript();
    }

    //添加游戏对象脚本，自动挂载
    private void AddGameObjectScript()
    {
        //得到层级视图的根对象
        GameObject goEnviromentRoot = GameObject.Find(ProjectConsts.MainGameScenes);

        //添加主角控制脚本
        GameObject.FindGameObjectWithTag(ProjectConsts.Player).AddComponent<Ctrl_HeroControl>();

        //动态挂载陆地移动脚本
        UnityHelper.AddChildNodeCompnent<Ctrl_LandMoving>(goEnviromentRoot, ProjectConsts.GameLanding);

        //动态挂载管道组移动脚本
        UnityHelper.AddChildNodeCompnent<Ctrl_PipesMoving>(goEnviromentRoot, ProjectConsts.GamePipes);

        //动态挂载管道道具
        for (int i = 1; i <= 3; i++)
        {
            UnityHelper.AddChildNodeCompnent<Ctrl_PipeAndLand>(goEnviromentRoot, "Pipe" + i + "_Down");
            UnityHelper.AddChildNodeCompnent<Ctrl_PipeAndLand>(goEnviromentRoot, "Pipe" + i + "_Up");
            //挂载陆地
            UnityHelper.AddChildNodeCompnent<Ctrl_PipeAndLand>(goEnviromentRoot, "Landing" + i);
        }

        //动态挂载金币道具
        for (int i = 1; i <= 3; i++)
        {
            UnityHelper.AddChildNodeCompnent<Ctrl_Golds>(goEnviromentRoot, "Pipe" + i + "_Trigger");
        }

        //动态挂载"得到时间"脚本
        goEnviromentRoot.AddComponent<Ctrl_GetTime>();

    }
}
