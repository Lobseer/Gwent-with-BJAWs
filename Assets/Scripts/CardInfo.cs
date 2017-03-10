using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization;

[DataContract]
public class CardInfo {
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public CardType Type { get; set; }
    [DataMember]
    public int Power { get; set; }
    [DataMember]
    public string Description { get; set; }
    [DataMember]
    public Texture2D Sprite { get; set; }

    public CardInfo(string name, CardType type, int power, string description)
    {
        Name = name;
        Type = type;
        Power = power;
        Description = description;
    }

}

public enum CardType
{
    Melee,
    Range,
    Siege,
    Universal
}
