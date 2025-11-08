using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actorinteractive : MonoBehaviour
{
    public ActorController ac;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        



    }

    public void Dodamager(Actorinteractive attacker)//传入攻击者
    {
        //print("Dodamager is called"+" "+attacker.name + "攻击了"+""+this.name);
        this.ac.data.AddHP(  Mathf.Min(  (-1 * (attacker.ac.data.TAK - this.ac.data.DEF)),0   )  );
        this.ac.anim.SetTrigger("hit");
        CheckHP();
    }

    public void CheckHP()
    {
        if (this.ac.data.HP <= 0)
        {
            this.ac.anim.SetTrigger("death");
        }
    }


}
