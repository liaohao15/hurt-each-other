using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponDataController : MonoBehaviour
{
    public weaponData wdata;
    public int ATKID = 1;

    public float TAK()
    {
        return wdata.TAK;
    }

    public void EQenable() 
    {
       wdata.state  = weaponData.STATE.ACTION;
    }
    public void EQdisable()
    {
        wdata.state = weaponData.STATE.IDLE;
        ATKID++;
    }

}
