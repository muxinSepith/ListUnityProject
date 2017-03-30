using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FileName: Model_GameDataProxy.cs
/// Author: 
/// Description: 数据层 --》 数据代理类
/// DateTime: 
/// </summary>
public class Model_GameDataProxy : Proxy
{
    //类的名称
    public new const string NAME = "Model_GameDataProxy";
    //游戏数据实体类
    private Model_GameData _GameData;


    public Model_GameDataProxy() : base(NAME)
    {
        _GameData = new Model_GameData();

        //得到最高分数
        _GameData.HightestScores = PlayerPrefs.GetInt(ProjectConsts.GameHightestScores);
    }

    //增加游戏的时间
    public void AddGameTime()
    {
        ++_GameData.GameTime;

        //数值发送到视图层
        SendNotification(ProjectConsts.Msg_DisplayGameInfo, _GameData);
    }

    //重置游戏时间
    public void ResetGameTime()
    {
        _GameData.GameTime = 0;
    }

    //增加分数
    public void AddScores()
    {
        ++_GameData.Scores;

        //跟新最高分数
        GetHightestScores();
    }

    //得到最高分数
    public int GetHightestScores()
    {
        if (_GameData.Scores > _GameData.HightestScores)
        {
            _GameData.HightestScores = _GameData.Scores;
        }
        return _GameData.HightestScores;
    }

    //保存最高分数
    public void SaveHightestScores()
    {
        if (_GameData.HightestScores > PlayerPrefs.GetInt(ProjectConsts.GameHightestScores))
        {
            PlayerPrefs.SetInt(ProjectConsts.GameHightestScores, _GameData.HightestScores);
        }
    }

}
