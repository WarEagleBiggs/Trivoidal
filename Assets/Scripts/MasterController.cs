using System;
using UnityEngine;
   
public enum CharacterType
{
    DevCharacter,
    SmileyCharacter,
    ToastedCharacter,
    SpaceCowboy,
    FootballPlayer,
    TheBat,
    Viking,
    Wastelander,
    SpaceSoldier,
    Speedster,
    Hedgehog,
    GoldFace
    
}

// --- MasterController serves as a singleton object among the scenes ---

public class MasterController
{
    private MasterController()
    {
        // --- private constructor ---

    }

    // singleton instance of self
    private static MasterController s_Instance;

    // single instance property accessor
    public static MasterController GetInstance =>
        s_Instance ?? (s_Instance = new MasterController());

    // --- public members ---

    [SerializeField]
    // character type
    public CharacterType m_CharacterType = CharacterType.ToastedCharacter;

    [SerializeField]
    public int m_TopScore;

    [SerializeField]
    public int m_TopCoinCount;
    
}
