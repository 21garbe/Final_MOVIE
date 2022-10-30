using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class DirectArriere : MonoBehaviour
{
    public Animator anim;
    // public ScoreSO MyScoreScript; // dans ce script, on doit avoir le booléeen ScoreHasUpdated qui vaut true dès que le score change dans update
    public GameObject whatToCall;
    public RuntimeAnimatorController newController;
    GameObject[] allPunch = new GameObject[1];
    private GameObject DirectArrièreLent;
    void Awake()
    {
        anim.runtimeAnimatorController = newController;
        DirectArrièreLent = Resources.Load<GameObject>("Sofia Animations/DirectArrièreLent");
    }

    // Use this for initialization
    void Start()
    {
        allPunch[0] = DirectArrièreLent;
        ChangePunch();
    }

    // Update is called once per frame
    void Update()
    {
        //ScoreUpdates = MyScoreScript.ScoreHasUpdated;
        // if (ScoreUpdates) {
        //     ChangePunch();
        //}
        //else {


        //}

    }

    public void ChangePunch()
    {
        int whichPunch = Random.Range(0, allPunch.Length);
        whatToCall = allPunch[whichPunch];
        anim.SetBool("DoUppercutArrièreLent", false);
        anim.SetBool("DoUppercutAvantLent", false);
        anim.SetBool("DoCrochetArrièreLent", false);
        anim.SetBool("DoCrochetAvantLent", false);
        anim.SetBool("DoDirectArrièreLent", false);
        anim.SetBool("DoDirectAvantLent", false);
        if (whatToCall == DirectArrièreLent)
        {
            anim.SetBool("DoDirectArrièreLent", true);
        }
    }
    public GameObject return_whatToCall()
    {
        return (whatToCall);
    }
}



