using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class CardData
{
    [SerializeField] private string name;
    public string Name { get { return name; } }
    [SerializeField] private RequirementData[] requirements;
    public RequirementData[] Requirements { get { return requirements; } }
    [SerializeField] private EffectData[] effects;
    public EffectData[] Effects { get { return effects; } }

    [SerializeField] private MechanicData[] telegraph;
    public MechanicData[] Telegraph { get { return telegraph; } }
    [SerializeField] private MechanicData[] focuses;
    public MechanicData[] Focuses { get { return focuses; } }
    [SerializeField] private MechanicData[] predictions;
    public MechanicData[] Predictions { get { return predictions; } }
    [SerializeField] private bool shouldReflex;
    public bool ShouldReflex { get { return shouldReflex; } }
    [SerializeField] private int player;
    public int Player { get { return player; } }
    [SerializeField] private int opponent;
    public int Opponent { get { return opponent; } }
    [SerializeField] private int priority;
    public int Priority { get { return priority; } }
    [SerializeField] private int clutch;
    public int Clutch { get { return clutch; } }
    [SerializeField] private bool isFaceUp;
    public bool IsFaceUp { get { return isFaceUp; } }
    [SerializeField] private string[] tags;
    public string[] Tags { get { return tags; } }

}