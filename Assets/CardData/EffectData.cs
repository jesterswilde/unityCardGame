using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class EffectData
{
    [SerializeField] private string mechanic;
    public string Mechanic { get { return mechanic; } }
    [SerializeField] private RequirementData[] mechanicRequirements;
    public RequirementData[] Requirements { get { return mechanicRequirements; } }
    [SerializeField] private EffectData[] mechanicEffects;
    public EffectData[] Effects { get { return mechanicEffects; } }
    [SerializeField] private string axis;
    public string Axis { get { return axis; } }
    [SerializeField] private Player player;
    public Player Player { get { return player; } }
    [SerializeField] private int amount;
    public int Amount { get { return amount; } }
    [SerializeField] EffectData[][] choices;
    public EffectData[][] Choices { get { return choices; } }


}

[Serializable]
public class MechanicData
{
    public const string TELEGRAPH = "Telegraph";
    public const string FOCUS = "Focus";
    public const string PREDICT = "Predict";
    public const string PARRY = "Parry";
    public const string BLOCK = "Block";
    public const string LOCK = "Lock";
    public const string REFLEX = "Reflex";
    public const string BUFF = "Buff";
    public const string CRIPPLE = "Cripple";
    public const string PICK_ONE = "Pick One";
    public const string FORCEFUL = "Forceful";
    public const string ENHANCE = "Enhance";
    public const string CLUTCH = "Clutch";
    public const string SETUP = "Setup";
    public const string RIGID = "Rigid";
    public const string FLUID = "Fluid";
}

[Serializable]
public class RequirementData
{
    [SerializeField] private string axis;
    public string Axis { get { return axis; } }
    [SerializeField] private Player player;
    public Player Player { get { return player; } }
    [SerializeField] private int amount;
    public int Amount { get { return amount; } }
}


public enum Player{
    ME, 
    THEM,
    BOTH
}

public class AxisVals{
    public const string DAMAGE = "Damage";
    public const string PRONE = "Prone";
    public const string STANDING = "Standing";
    public const string MOVING = "Moving";
    public const string STILL = "Still";
    public const string GRAPPLED = "Grappled";
    public const string NOT_GRAPPLED = "Not Grappled";
    public const string CLOSE = "Close";
    public const string NOT_CLOSE = "Not Close";
    public const string FAR = "Far";
    public const string NOT_FAR = "Not Far";
    public const string BALANCED = "Balanced";
    public const string UNBALANCED = "Unbalanced";
    public const string ANTICIPATING = "Anticipating";
    public const string NOT_ANTICIPATING = "Not Anticipating";
    public const string CLOSER = "Closer";
    public const string FURTHER = "Further";
    public const string BLOODIED = "Bloodied";
    public const string FRESH = "Fresh";
    public const string MOTION = "Motion";
    public const string DISTANCE = "Distance";
    public const string POISE = "Poise";
    public const string LOSE_POISE = "Lose Poise";
    public const string STANCE = "Stance";
}
