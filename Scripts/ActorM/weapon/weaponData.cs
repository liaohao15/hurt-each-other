using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class weaponData : MonoBehaviour
{
    public enum STATE { IDLE, ACTION }
    public STATE state;

    [Header("== Current data == ")]
    public float TAK = 10.0f;


    public void OnTriggerEnter(Collider col)
    {
        if(state == STATE.ACTION)
        { 
            Actorinteractive im = col.GetComponent<Actorinteractive>();
            if (im != null)
            {
                im.Dodamager(GetComponentInParent<Actorinteractive>());
                print(im);
            }
        }
            

     }

}
