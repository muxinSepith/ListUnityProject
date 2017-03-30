using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUIFW;

/// <summary>
/// FileName: GameStart.cs
/// Author: 
/// Description: 
/// DateTime: 
/// </summary>
public class GameStart : MonoBehaviour 
{
    
    void Start()
    {
        UIManager.GetInstance().ShowUIForms(ProjectConsts.StartUIForm);
    }
	
}
