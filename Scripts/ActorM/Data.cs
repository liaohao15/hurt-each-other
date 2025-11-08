using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    [Range(0,200f)]
    public float MaxHP = 200.0f;//最大血量

    public Image blood;

    [Header("== Current data == ")]
    public float HP = 100.0f;
    public float TAK = 10.0f;
    public float DEF = 5.0f;

    private void Start()
    {
        Bloodupdate();
    }


    public void AddHP(float value)//接收交互系统，传来的value值
    {
        HP = HPChange(HP + value,0,MaxHP);//应用HPChange方法
        Bloodupdate();
    }

    private float HPChange(float value,float min,float max)//传进来，这三个值
    { 
        return Mathf.Clamp(value, min, max);//将 （HP+value）限制在min 和 max之间
    }

    private void Bloodupdate()
    {
        blood.fillAmount = HP / MaxHP;
    }

    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
