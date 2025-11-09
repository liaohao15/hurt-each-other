using JetBrains.Annotations;
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

    public Actorinteractive am1;
    public Actorinteractive am2;


    [Space(10)]//添加间隔
    [Header("==  STATE GAME  ==")]
    public STATE state;


    public bool FirstEnter = true;
   
    //一次执行
    // Start is called before the first frame update
    void Start()
    {
        
    }


    //重复执行
    // Update is called once per frame
    void Update()
    {

        if (state == STATE.IDLE)
        {
            if (FirstEnter == true)
            {
                StartCoroutine("TAKIDLE");
                FirstEnter = false;
            }
            else
            {
                CheckVictory();
            }

            //if (Input.GetKeyDown(KeyCode.Q))
            //{
            //    state = STATE.PLAYERA;
            //    ac1.anim.SetTrigger("attack");
            //    //ac2.data.AddHP(-1 * ac1.data.TAK);//要呼叫Actorinteractive
            //    //am2.Dodamager(am1);//am1是攻击者，am2是被攻击者

            //}
        }
        else if (state == STATE.PLAYERA)
        {
            if (FirstEnter == true)
            {
                StartCoroutine("TAKPLAYERA");
                FirstEnter = false;
            }
            else
            {
                CheckVictory();
            }

            //if (Input.GetKeyDown(KeyCode.Q))
            //{
            //    state = STATE.PLAYERB;
            //    ac2.anim.SetTrigger("attack");
            //    //ac1.data.AddHP(-1 * ac2.data.TAK);
            //    //am1.Dodamager(am2);
            //}
        }
        else if (state == STATE.PLAYERB)
        {
            if (FirstEnter == true)
            {
                StartCoroutine("TAKPLAYERB");
                FirstEnter = false;
            }
            else
            {
                CheckVictory();
            }

            //if (Input.GetKeyDown(KeyCode.Q))
            //{
            //    state = STATE.IDLE;
            //}
        }
        else if (state == STATE.FINISHED)
        {
            if (FirstEnter == true)
            {
                StopCoroutine("TAKIDLE");
                StopCoroutine("TAKPLAYERA");
                StopCoroutine("TAKPLAYERB");
            }
        }    
    }
    public void CheckVictory()//用这个方法，代替重复的代码
    {
        if (ac1.data.HP <= 0 || ac2.data.HP <= 0)
        {
            state = STATE.FINISHED;
            FirstEnter = true;
        }
    }

    IEnumerator TAKIDLE()
    {
        yield return new  WaitForSeconds(1.0f);//暂停1秒钟，接着做下面的代码
        state = STATE.PLAYERA;
        ac1.anim.SetTrigger("attack");
        FirstEnter = true;
    }
    IEnumerator TAKPLAYERA()
    {
        yield return new WaitForSeconds(1.0f);
        state = STATE.PLAYERB;
        ac2.anim.SetTrigger("attack");
        FirstEnter = true;
    }
    IEnumerator TAKPLAYERB()//迭代器
    {
        yield return new WaitForSeconds(1.0f);//暂停1秒钟，接着做下面的代码
        state = STATE.IDLE;
        FirstEnter = true;
    }
     

}
