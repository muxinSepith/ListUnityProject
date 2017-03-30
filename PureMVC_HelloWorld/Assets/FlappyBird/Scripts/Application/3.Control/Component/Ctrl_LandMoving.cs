using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FileName: Ctrl_LandMoving.cs
/// Author: 
/// Description: 控制层 --》 陆地移动
/// DateTime: 
/// </summary>
public class Ctrl_LandMoving : MonoBehaviour
{

    public float floMovingSpeed = 2f;               //陆地移动速度
    private Vector2 _VecOriginalPosition;          //陆地原始位置

    void Start()
    {
        //保存陆地原始位置
        _VecOriginalPosition = transform.position;
    }

    void Update()
    {
        //陆地循环移动，到了临界值，恢复原始方位
        if (transform.position.x < -5f)
        {
            transform.position = _VecOriginalPosition;
        }

        //移动
        transform.Translate(Vector2.left * Time.deltaTime * floMovingSpeed);
    }
}
