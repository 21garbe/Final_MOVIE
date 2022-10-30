using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class TOE : MonoBehaviour
{   
    public bool active;
    public GameObject Player;
    public GameObject Hand_1;
    public GameObject Hand_2;
    public GameObject Head_1;
    List<Vector3> List_LHand_ref = new List<Vector3>();
    List<Vector3> List_Rhand_ref = new List<Vector3>();
    List<Vector3> List_Head_ref = new List<Vector3>();
    List<Vector3> List_LHand_player = new List<Vector3>();
    List<Vector3> List_Rhand_player = new List<Vector3>();
    List<Vector3> List_Head_player = new List<Vector3>();
    public GameObject prefabToInstantiate;
    public GameObject Right_Hand;
    public GameObject Left_Hand;
    public GameObject Head;
    GameObject g;
    Transform transforme;
    Transform LHand_ref ;
    Transform RHand_ref;
    Transform Head_ref;
    Transform Right_Hplayer;
    Transform Left_Hplayer;
    Transform Head_player;
    Vector3 Vector;
    public UnityEvent display_score_function;
    public UnityEvent ChangePunch;
    public UnityEvent ChangeEsquive;
    double score = 0;
    public ScoreSO Score_SO;
    
    public GameObject CreateObject()
        { 
            transform.position = new Vector3(0, 0, 0);
            return (Instantiate(prefabToInstantiate));
        }
    
    GameObject g1;
    GameObject g2;

    public void setactive()
    {
        active = true;
    }
    public void Compute_Score()
    {
        score = 0;
        int taille = List_LHand_ref.Count;
        for (int i = 0; i < taille; i++)
        { 
            for (int j = 0; j < 3; j++)
            {
                double vect = Convert.ToSingle(List_LHand_ref[i][j] - List_LHand_player[i][j]);
                score += Math.Pow(vect,2);
                vect = Convert.ToSingle(List_Rhand_ref[i][j] - List_Rhand_player[i][j]);
                score += Math.Pow(vect, 2);
                vect = Convert.ToSingle(List_Head_ref[i][j] - List_Head_player[i][j]);
                score += Math.Pow(vect, 2);
            };
        }
        Debug.Log(score);
        Score_SO.score = (int)Math.Round(score);
        display_score_function?.Invoke();
        ChangePunch?.Invoke();
        Debug.Log(score);
        ChangeEsquive?.Invoke();
        Clear_lists();
        active = false;
    }

    void Clear_lists()
    {
     List_LHand_ref = new List<Vector3>();
      List_Rhand_ref = new List<Vector3>();
     List_Head_ref = new List<Vector3>();
        List_LHand_player = new List<Vector3>();
         List_Rhand_player = new List<Vector3>();
        List_Head_player = new List<Vector3>();

    }
    // Start is called before the first frame update
    void Start()
    {
        active = false;
        Player = GameObject.Find("Player");
        g1 = CreateObject();
        g2 = CreateObject();
    }

    // Update is called once per frame
    void Update()
    {   if (active)
    {
        LHand_ref = Hand_1.transform; 
        Vector = LHand_ref.position;
        List_LHand_ref.Add(Vector);
        g1.transform.position = LHand_ref.position;
        
        RHand_ref = Hand_2.transform;         
        Vector = RHand_ref.position;
        List_Rhand_ref.Add(Vector);
        //g.transform.position = RHand_ref.position;

        Head_ref = Head_1.transform; 
        Vector = Head_ref.position;
        List_Head_ref.Add(Vector);
        //g.transform.position = Head_ref.position;
        
        Right_Hplayer = Right_Hand.transform;
        Vector = Right_Hplayer.position;
        List_LHand_player.Add(Vector);
        //g.transform.position = Right_Hplayer.position;
   
        Left_Hplayer = Left_Hand.transform;
        Vector = Left_Hplayer.position;
        List_Rhand_player.Add(Vector);
        g2.transform.position = Left_Hplayer.position;
  
        Head_player = Head.transform;
        Vector = Head_player.position;
        List_Head_player.Add(Vector);
        //g.transform.position = Head_player.position;
    }
        
    }
}
