using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actorinteractive : MonoBehaviour
{
    public ActorController ac;
    public ActorDataController adc;
    public weaponDataController wdc;
    
    private int LastTAKID = 0;

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

        if (LastTAKID != attacker.wdc.ATKID)
        {
            //print("Dodamager is called"+" "+attacker.name + "攻击了"+""+this.name);
            this.adc.data.AddHP(Mathf.Min((-1 * (attacker.adc.TAK() + attacker.wdc.TAK() - this.adc.DEF())), 0));
            this.ac.anim.SetTrigger("hit");
            CheckHP();
            print("attacker.wdc.ATKID=" + attacker.wdc.ATKID);
            LastTAKID = attacker.wdc.ATKID;
        }
        
    }

    public void CheckHP()
    {
        if (this.adc.HP() <= 0)//读取ActorDataController的血条
        {
            this.ac.anim.SetTrigger("death");
        }
    }


}
