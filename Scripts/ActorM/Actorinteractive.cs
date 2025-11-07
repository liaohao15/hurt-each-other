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
        if (Input.GetKeyDown(KeyCode.T))
        {
            print(""+ ac.data.HP);
            ac.data.AddHP(+10);
        }



    }
}
