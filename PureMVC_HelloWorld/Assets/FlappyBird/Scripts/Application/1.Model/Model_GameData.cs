using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FileName: Model_GameData.cs
/// Author: 
/// Description: 模型层 --》 实体类 
/// 定义小鸟的相关数据： 
/// 1.时间
/// 2.分数
/// 3.最高分数
/// DateTime: 
/// </summary>
public class Model_GameData
{
    //游戏时间
    public int GameTime { get; set; }
    //游戏分数
    public int Scores { get; set; }
    //游戏最高分数
    public int HightestScores { get; set; }
}
