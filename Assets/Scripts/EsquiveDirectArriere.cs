
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;
using Valve.VR;
using UnityEngine.Events;

public class EsquiveDirectArriere : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    public RuntimeAnimatorController newController;
    public ScoreSO MyScoreScript;
    public DirectArriere DirectArriere;
    public bool active ;    
    private GameObject UppercutArri�reLent_esquive;
    private GameObject UppercutAvantLent_esquive;
    private GameObject CrochetArri�reLent_esquive;
    private GameObject CrochetAvantLent_esquive;
    private GameObject DirectArri�reLent_esquive;
    private GameObject DirectAvantLent_esquive;
    private GameObject UppercutArri�reLent;
    private GameObject UppercutAvantLent;
    private GameObject CrochetArri�reLent;
    private GameObject CrochetAvantLent;
    private GameObject DirectArri�reLent;
    private GameObject DirectAvantLent;

    

    void Awake()
    { 
        anim.runtimeAnimatorController = newController;
       
        UppercutArri�reLent_esquive = Resources.Load<GameObject>("Sofia Animations/Esquive/retrait");

        UppercutAvantLent_esquive = Resources.Load<GameObject>("Sofia Animations/Esquive/retrait");
    
        DirectAvantLent_esquive = Resources.Load<GameObject>("Sofia Animations/Esquive/esquive_droite");
       
        DirectArri�reLent_esquive = Resources.Load<GameObject>("Sofia Animations/Esquive/esquive_gauche");
        
        CrochetAvantLent_esquive = Resources.Load<GameObject>("Sofia Animations/Esquive/esquive_dessous_droite");
        
        CrochetArri�reLent_esquive = Resources.Load<GameObject>("Sofia Animations/Esquive/esquive_dessous_gauche");

        UppercutArri�reLent = Resources.Load<GameObject>("Sofia Animations/UppercutArri�reLent");
        UppercutAvantLent = Resources.Load<GameObject>("Sofia Animations/UppercutAvantLent");
        DirectAvantLent = Resources.Load<GameObject>("Sofia Animations/DirectAvantLent");
        DirectArri�reLent = Resources.Load<GameObject>("Sofia Animations/DirectArri�reLent");
        CrochetAvantLent = Resources.Load<GameObject>("Sofia Animations/CrochetAvantLent");
        CrochetArri�reLent = Resources.Load<GameObject>("Sofia Animations/CrochetArri�reLent");
    }
    public void TriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Trigger is down");
        ChangeEsquive();
    }

    // Use this for initialization
    public void activate_esquive()
    {
        anim.SetBool("active", true);
        Debug.Log("esquive active");
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void ChangeEsquive()
    {
         Debug.Log(1);

            GameObject whatToCall = DirectArriere.whatToCall;
            Debug.Log(whatToCall);
            anim.SetBool("DoUppercutArri�reLent", false);
            anim.SetBool("DoUppercutAvantLent", false);
            anim.SetBool("DoCrochetArri�reLent", false);
            anim.SetBool("DoCrochetAvantLent", false);
            anim.SetBool("DoDirectArri�reLent", false);
            anim.SetBool("DoDirectAvantLent", false);
            anim.SetBool("DoTroisDirectsLents", false);
            if (whatToCall == DirectArri�reLent)
            {
                anim.SetBool("DoDirectArri�reLent", true);
            }
        anim.SetBool("active", false);
        

           
    }
}
