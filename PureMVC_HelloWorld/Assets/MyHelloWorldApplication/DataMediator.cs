using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PureMVC;
using PureMVC.Interfaces;
using PureMVC.Patterns;

namespace PureMVCDemo
{

    public class DataMediator : Mediator
    {
        public new const string NAME = "DataMediator";

        private Text TxtLevel;
        private Button BtnDisplayLevelNum;

        public DataMediator(GameObject goRootNode)
        {
            //查找到控件
            TxtLevel = goRootNode.transform.FindChild("Text").GetComponent<Text>();
            BtnDisplayLevelNum = goRootNode.transform.FindChild("Button").GetComponent<Button>();

            //注册按钮
            BtnDisplayLevelNum.onClick.AddListener(OnClickAddingLevelNumber);
        }

        //用户点击事件
        private void OnClickAddingLevelNumber()
        {
            Debug.Log("发送点击事件 ---》 视图层");

            //定义消息，发送到控制层
            SendNotification("Reg_StartDataCommand");
        }

        /// <summary>
        /// 本视图层，允许接受的消息
        /// </summary>
        /// <returns></returns>
        public override IList<string> ListNotificationInterests()
        {
            IList<string> listResult = new List<string>();

            //可以接受的消息（集合）
            listResult.Add("Msg_AddLevel");

            return listResult;
        }

        /// <summary>
        /// 处理所有其他类，发给本类允许处理的消息
        /// </summary>
        /// <param name="notification"></param>
        public override void HandleNotification(INotification notification)
        {
            switch (notification.Name)
            {
                case "Msg_AddLevel":
                    //把模型层发来的数据，显示给控件
                    Debug.Log("处理增加等级的事件 ---》 视图层");

                    //获取到数据
                    MyData myData = notification.Body as MyData;

                    //显示数据
                    TxtLevel.text = myData.Level.ToString();
                    break;

                default:
                    break;
            }
        }
    }

}
