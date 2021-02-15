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

class GameState
{
    [SerializeField]
    // character type
    public CharacterType m_CharacterType = CharacterType.ToastedCharacter;

    [SerializeField]
    public int m_TopScore;

    [SerializeField]
    public int m_TopCoinCount;

    [SerializeField]
    public float m_CurrentScore;

    [SerializeField]
    public int m_DeathCount;
}


// --- MasterController serves as a singleton object among the scenes ---

public class MasterController
{
    private MasterController()
    {
        // --- private constructor ---

        m_State = new GameState();

        // Deserialize and restore score HERE!!!!!!!!
        Deserialize();
    }
  
    // singleton instance of self
    private static MasterController s_Instance;

    // single instance property accessor
    public static MasterController GetInstance =>
        s_Instance ?? (s_Instance = new MasterController());

    public bool m_IsAudioEnabled = true;
    public int m_CoinsGathered = 0;

    public void Serialize()
    {
        // --- Save state ----

        string dataString = JsonUtility.ToJson(m_State);
        PlayerPrefs.SetString("GameState", dataString);
    }

    public void Deserialize()
    {
        // --- Restore state from previous session ---

        string dataString = PlayerPrefs.GetString("GameState");
        if (dataString != "") { 
            m_State = JsonUtility.FromJson<GameState>(dataString);
        }
    }

    // game state storage
    private GameState m_State;

    public CharacterType CharacterType
    {
        get => m_State.m_CharacterType;
        set => m_State.m_CharacterType = value;
    }
   
    public int TopScore
    {
        get => m_State.m_TopScore;
        set => m_State.m_TopScore = value;
    }

    public int TopCoinCount
    {
        get => m_State.m_TopCoinCount;
        set => m_State.m_TopCoinCount = value;
    }

    public int DeathCount
    {
        get => m_State.m_DeathCount;
        set => m_State.m_DeathCount = value;
    }

    public float CurrentScore
    {
        get => m_State.m_CurrentScore;
        set => m_State.m_CurrentScore = value;
    }
}
