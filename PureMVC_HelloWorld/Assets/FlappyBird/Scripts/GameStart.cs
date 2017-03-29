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

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        UIManager.GetInstance().ShowUIForms("StartUIForm");
    }
	
}
