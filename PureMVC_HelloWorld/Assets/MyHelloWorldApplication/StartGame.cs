using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PureMVCDemo
{

    public class StartGame : MonoBehaviour
    {

        void Start()
        {
            //启动PureMVC框架
            new ApplicationFacade(this.gameObject);
        }

    }

}