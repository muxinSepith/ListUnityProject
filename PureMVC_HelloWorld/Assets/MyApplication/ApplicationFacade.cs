using System.Collections;
using System.Collections.Generic;
using PureMVC.Patterns;
using UnityEngine;

namespace PureMVCDemo
{
    public class ApplicationFacade : Facade
    {

        public ApplicationFacade(GameObject goRootNode)
        {
            /* MVC 三层的关联绑定 */

            //控制层注册（将消息和控制层类进行绑定，通过发送消息，触发对应类中的Execute方法）
            RegisterCommand("Reg_StartDataCommand",typeof(DataCommand));
            
            //视图层注册
            RegisterMediator(new DataMediator(goRootNode));
            //模型层注册
            RegisterProxy(new DataProxy());
        }

    }
}
