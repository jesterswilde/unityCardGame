using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CardManager : MonoBehaviour
{
    string fileName = "./Assets/Clinch.json";
    // Start is called before the first frame update
    void Start()
    {
        using (StreamReader r = new StreamReader(fileName))
        {
            var json = r.ReadToEnd();
            CardData card = JsonUtility.FromJson<CardData>(json);
            Debug.Log(json); 
            Debug.Log(card.Name);
            Debug.Log("Requirements:");
            Debug.Log(card.Requirements); 
            foreach(var req in card.Requirements){
                Debug.Log(req.Player +" | " + req.Axis + " | " + req.Amount);
            }
            Debug.Log("Effects: "); 
            foreach(var eff in card.Effects){
                Debug.Log(eff.Mechanic + " | " +  eff.Player + " | " + eff.Axis + " | " + eff.Amount); 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
