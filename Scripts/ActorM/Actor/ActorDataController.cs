using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorDataController : MonoBehaviour
{
    public Data data;


    public float TAK() 
    {
        return data.TAK;//读取人物的攻击
    }

    public float DEF()
    { 
        return data.DEF;//读取人物的防御
    }

    public float HP()//读取人物的血量
    {
        return data.HP;
    }




}
