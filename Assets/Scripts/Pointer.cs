using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pointer : MonoBehaviour
{
    public float range = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetButtonDown("Fire1")||Input.GetButtonDown("Fire2"))
        // {
        //     RayRecever cible = GetObjPointe();
        //     if (cible!=null)
        //     {
        //         if (Input.GetButtonDown("Fire1"))
        //         {
        //             if (cible.flagged==false)
        //             {
        //                 cible.Activate();
        //             }
        //         }
        //         else if (Input.GetButtonDown("Fire2"))
        //         {
        //             cible.flag();
        //         }
        //     }
        // }
    }

    public void OnFlagKey(InputAction.CallbackContext context)
    {
        RayRecever cible = GetObjPointe();
        if (cible!=null)
        {
            cible.flag();
        }
    }
    public void OnFireKey(InputAction.CallbackContext context)
    {
        RayRecever cible = GetObjPointe();
        if (cible!=null)
        {
            if (cible.flagged==false)
            {
                cible.Activate();
            }
        }
    }

    private RayRecever GetObjPointe()
    {
        RaycastHit hit_info;
        if (Physics.Raycast(transform.position,transform.forward,out hit_info, range))
        {
            return hit_info.transform.GetComponent<RayRecever>();
        }
        else
        {
            return null;
        }
    }
}
