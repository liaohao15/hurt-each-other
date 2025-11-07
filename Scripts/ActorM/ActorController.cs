using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour
{
    //变数变量区
    public Animator anim;//定义一个anim用来控制Animator组件
    public Data data;

    //一次性代码区
    void Start()
    {
        
    }

    // 重复代码区
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))//“A”键控制攻击
        {
            anim.SetTrigger("attack");
        }

        if (Input.GetKeyDown(KeyCode.D))//“D”键控制受击
        {
            anim.SetTrigger("hit");
        }

    }
}
