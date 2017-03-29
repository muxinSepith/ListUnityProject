using SUIFW;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FileName: StartUIForm.cs
/// Author: 
/// Description: 
/// DateTime: 
/// </summary>
public class StartUIForm : BaseUIForm
{

    private void Awake()
    {
        //按钮注册
        RigisterButtonObjectEvent("ImgBackground", p =>
             OpenUIForm("GameGuideUIForm")
        );
    }

    private void Start()
    {
        //启动MVC框架
        new ApplicationFacade();
    }

}
