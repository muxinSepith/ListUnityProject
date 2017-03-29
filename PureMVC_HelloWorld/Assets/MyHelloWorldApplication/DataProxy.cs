using System.Collections;
using System.Collections.Generic;
using PureMVC.Patterns;
using UnityEngine;

namespace PureMVCDemo
{
    public class DataProxy : Proxy
    {
        //本类名称
        public new const string NAME = "DataProxy";
        //引用”实体类”
        private MyData _MyData = null;

        /// <summary>
        /// 构造函数
        /// </summary>
        public DataProxy() : base(NAME)
        {
            _MyData = new MyData();
        }

        /// <summary>
        /// 增加玩家的等级
        /// </summary>
        /// <param name="addNumber">增加的等级数量</param>
        public void AddLevel(int addNumber)
        {
            _MyData.Level += addNumber;

            Debug.Log("发送增加等级的消息 ---》 数据层");

            SendNotification("Msg_AddLevel",_MyData);
        }

    }
}
