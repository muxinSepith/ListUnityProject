using System.Collections;
using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using UnityEngine;

namespace PureMVCDemo
{

    public class DataCommand : SimpleCommand
    {
        /// <summary>
        /// 执行方法
        /// </summary>
        /// <param name="notification"></param>
        public override void Execute(INotification notification)
        {
            Debug.Log("处理点击事件 ---》 控制层");

            //调用数据层的“增加等级“的方法
            DataProxy datapro =(DataProxy) Facade.RetrieveProxy(DataProxy.NAME);
            datapro.AddLevel(10);
        }
    }

}