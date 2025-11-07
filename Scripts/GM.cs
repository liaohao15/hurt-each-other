using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    //变量
    public enum STATE { IDLE, PLAYERA, PLAYERB, FINISHED }//使用下拉菜单

    [Header("==  Parameters  ==")]//使用名称
    [Range(0, 10f)]//使用滑杆
    public float i = 0;

    [Space(10)]//添加间隔
    [Header("==  ActorController Setting  ==")]
    public ActorController ac1;
    public ActorController ac2;

    [Space(10)]//添加间隔
    [Header("==  STATE GAME  ==")]
    public STATE state;

   
    //一次执行
    // Start is called before the first frame update
    void Start()
    {
        
    }


    //重复执行
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (state == STATE.IDLE)
            {
                state = STATE.PLAYERA;
                ac1.anim.SetTrigger("attack");
                ac2.anim.SetTrigger("hit");

            }
            else if (state == STATE.PLAYERA)
            {
                state = STATE.PLAYERB;
            }
            else if (state == STATE.PLAYERB)
            {
                state = STATE.FINISHED;
            }
            else if (state == STATE.FINISHED)
            {
                state = STATE.IDLE;
            }
        }
    }
}
