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

//[Serializable]
//public class GameState
//{
//    [SerializeField]
//    // character type
//    public CharacterType m_CharacterType = CharacterType.ToastedCharacter;

//    [SerializeField]
//    public int m_TopScore;

//    [SerializeField]
//    public int m_TopCoinCount;

//    [SerializeField]
//    public float m_CurrentScore;

//    [SerializeField]
//    public int m_DeathCount;

//}

// --- MasterController serves as a singleton object among the scenes ---

public class MasterController
{
    private MasterController()
    {
        // --- private constructor ---

        // TODO Deserialize and restore score HERE!!!!!!!!

        //m_State = new GameState();

        //Deserialize();
    }
  
    // singleton instance of self
    private static MasterController s_Instance;

    // single instance property accessor
    public static MasterController GetInstance =>
        s_Instance ?? (s_Instance = new MasterController());


    //public void Serialize()
    //{
    //    // --- Save state ----

    //    string dataString = JsonUtility.ToJson(m_State);
    //    PlayerPrefs.SetString("GameState", dataString);
    //    Debug.Log(dataString);
    //}

    //public void Deserialize()
    //{
    //    // --- Restore state from previous session ---

    //    string dataString = PlayerPrefs.GetString("GameState");
    //    m_State = JsonUtility.FromJson<GameState>(dataString);

    //}


    // --- public members ---


    //public GameState m_State;

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
