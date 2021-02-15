using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.Audio;

public class SceneController : MonoBehaviour
{

    private MasterController m_Controller;

    public GameObject m_PlayerPicker;

    public GameObject m_AnnoyingUI;

    public GameObject m_AnnoyingUI2;

    public GameObject m_AnnoyingUI3;

    public GameObject m_AnnoyingUI4;

    public GameObject m_AnnoyingUI5;

    public TMP_Text m_TopScoreText;

    public TMP_Text m_TopCoinCountText;

    public GameObject Music1;

    //public bool isAudioON = true;

    //SelectedPlayerDisplay
    public GameObject m_SmileyDisplay;
    public GameObject m_DevDisplay;
    public GameObject m_CowboyDisplay;
    public GameObject m_FootballDisplay;
    public GameObject m_TheBatDisplay;
    public GameObject m_VikingDisplay;
    public GameObject m_WastelanderDisplay;
    public GameObject m_SpaceSoldierDisplay;
    public GameObject m_SpeedsterDisplay;
    public GameObject m_HedgehogDisplay;
    public GameObject m_GoldFaceDisplay;
    public GameObject m_ToastedDisplay;


    // associative map of character name and whether playable
    private Dictionary<CharacterType, bool> m_PlayableCharacterMap;

    // associative map of character name and price to buy
    private Dictionary<CharacterType, int> m_CharacterPriceMap;

    public AdManager AdMan;
    
    
    public void ShowAd()
    {
        AdMan.StartCoroutine("ShowAd");
        m_Controller.TopCoinCount = m_Controller.TopCoinCount + 10;
        

    }

    public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void ToggleMusic()
    {
        Music1.SetActive(!Music1.activeSelf);
        m_Controller.m_IsAudioEnabled = !m_Controller.m_IsAudioEnabled;
        
  
    }

    private void InitPlayerCharMap()
    {
        // Create map
        m_PlayableCharacterMap = new Dictionary<CharacterType, bool>();
        
        // Initialize state
        m_PlayableCharacterMap[CharacterType.ToastedCharacter] = true;
        m_PlayableCharacterMap[CharacterType.DevCharacter] = false;
        m_PlayableCharacterMap[CharacterType.FootballPlayer] = false;
        m_PlayableCharacterMap[CharacterType.GoldFace] = false;
        m_PlayableCharacterMap[CharacterType.Hedgehog] = false;
        m_PlayableCharacterMap[CharacterType.SmileyCharacter] = false;
        m_PlayableCharacterMap[CharacterType.SpaceCowboy] = false;
        m_PlayableCharacterMap[CharacterType.SpaceSoldier] = false;
        m_PlayableCharacterMap[CharacterType.Speedster] = false;
        m_PlayableCharacterMap[CharacterType.TheBat] = false;
        m_PlayableCharacterMap[CharacterType.Viking] = false;
        m_PlayableCharacterMap[CharacterType.Wastelander] = false;

    }

    private bool IsCharacterPlayable(CharacterType type)
    {   
        return m_PlayableCharacterMap[type];
    }

    private void Start()
    {
        m_Controller = MasterController.GetInstance;

        if (m_PlayableCharacterMap == null) {
            InitPlayerCharMap();
        }

        if (m_CharacterPriceMap == null) {
            InitCharPriceMap();
        }

         
        
        Music1.SetActive(m_Controller.m_IsAudioEnabled);
        
    }
    

    public void OnPlayerSelectButton()
    {
        

        string btnName = EventSystem.current.currentSelectedGameObject.name;

        if (btnName == "DevPlayer" && IsCharacterPlayable(CharacterType.DevCharacter)) {
            m_Controller.CharacterType = CharacterType.DevCharacter;
            m_DevDisplay.SetActive(true);
            m_ToastedDisplay.SetActive(false);
            m_SmileyDisplay.SetActive(false);
            m_CowboyDisplay.SetActive(false);
            m_FootballDisplay.SetActive(false);
            m_TheBatDisplay.SetActive(false);
            m_VikingDisplay.SetActive(false);
            m_WastelanderDisplay.SetActive(false);
            m_SpaceSoldierDisplay.SetActive(false);
            m_SpeedsterDisplay.SetActive(false);
            m_HedgehogDisplay.SetActive(false);
            m_GoldFaceDisplay.SetActive(false);
        } else if (btnName == "ToastedPlayer" && IsCharacterPlayable(CharacterType.ToastedCharacter)) {
            m_Controller.CharacterType = CharacterType.ToastedCharacter;
            m_DevDisplay.SetActive(false);
            m_ToastedDisplay.SetActive(true);
            m_SmileyDisplay.SetActive(false);
            m_CowboyDisplay.SetActive(false);
            m_FootballDisplay.SetActive(false);
            m_TheBatDisplay.SetActive(false);
            m_VikingDisplay.SetActive(false);
            m_WastelanderDisplay.SetActive(false);
            m_SpaceSoldierDisplay.SetActive(false);
            m_SpeedsterDisplay.SetActive(false);
            m_HedgehogDisplay.SetActive(false);
            m_GoldFaceDisplay.SetActive(false);
        } else if (btnName == "SmileyPlayer" && IsCharacterPlayable(CharacterType.SmileyCharacter)) {
            m_Controller.CharacterType = CharacterType.SmileyCharacter;
            m_DevDisplay.SetActive(false);
            m_ToastedDisplay.SetActive(false);
            m_SmileyDisplay.SetActive(true);
            m_CowboyDisplay.SetActive(false);
            m_FootballDisplay.SetActive(false);
            m_TheBatDisplay.SetActive(false);
            m_VikingDisplay.SetActive(false);
            m_WastelanderDisplay.SetActive(false);
            m_SpaceSoldierDisplay.SetActive(false);
            m_SpeedsterDisplay.SetActive(false);
            m_HedgehogDisplay.SetActive(false);
            m_GoldFaceDisplay.SetActive(false);
        } else if (btnName == "SpaceCowboy" && IsCharacterPlayable(CharacterType.SpaceCowboy)) {
            m_Controller.CharacterType = CharacterType.SpaceCowboy;
            m_DevDisplay.SetActive(false);
            m_ToastedDisplay.SetActive(false);
            m_SmileyDisplay.SetActive(false);
            m_CowboyDisplay.SetActive(true);
            m_FootballDisplay.SetActive(false);
            m_TheBatDisplay.SetActive(false);
            m_VikingDisplay.SetActive(false);
            m_WastelanderDisplay.SetActive(false);
            m_SpaceSoldierDisplay.SetActive(false);
            m_SpeedsterDisplay.SetActive(false);
            m_HedgehogDisplay.SetActive(false);
            m_GoldFaceDisplay.SetActive(false);
        } else if (btnName == "FootballPlayer" && IsCharacterPlayable(CharacterType.FootballPlayer)) {
            m_Controller.CharacterType = CharacterType.FootballPlayer;
            m_DevDisplay.SetActive(false);
            m_ToastedDisplay.SetActive(false);
            m_SmileyDisplay.SetActive(false);
            m_CowboyDisplay.SetActive(false);
            m_FootballDisplay.SetActive(true);
            m_TheBatDisplay.SetActive(false);
            m_VikingDisplay.SetActive(false);
            m_WastelanderDisplay.SetActive(false);
            m_SpaceSoldierDisplay.SetActive(false);
            m_SpeedsterDisplay.SetActive(false);
            m_HedgehogDisplay.SetActive(false);
            m_GoldFaceDisplay.SetActive(false);
        } else if (btnName == "TheBat" && IsCharacterPlayable(CharacterType.TheBat)) {
            m_Controller.CharacterType = CharacterType.TheBat;
            m_DevDisplay.SetActive(false);
            m_ToastedDisplay.SetActive(false);
            m_SmileyDisplay.SetActive(false);
            m_CowboyDisplay.SetActive(false);
            m_FootballDisplay.SetActive(false);
            m_TheBatDisplay.SetActive(true);
            m_VikingDisplay.SetActive(false);
            m_WastelanderDisplay.SetActive(false);
            m_SpaceSoldierDisplay.SetActive(false);
            m_SpeedsterDisplay.SetActive(false);
            m_HedgehogDisplay.SetActive(false);
            m_GoldFaceDisplay.SetActive(false);
        } else if (btnName == "Viking" && IsCharacterPlayable(CharacterType.Viking)) {
            m_Controller.CharacterType = CharacterType.Viking;
            m_DevDisplay.SetActive(false);
            m_ToastedDisplay.SetActive(false);
            m_SmileyDisplay.SetActive(false);
            m_CowboyDisplay.SetActive(false);
            m_FootballDisplay.SetActive(false);
            m_TheBatDisplay.SetActive(false);
            m_VikingDisplay.SetActive(true);
            m_WastelanderDisplay.SetActive(false);
            m_SpaceSoldierDisplay.SetActive(false);
            m_SpeedsterDisplay.SetActive(false);
            m_HedgehogDisplay.SetActive(false);
            m_GoldFaceDisplay.SetActive(false);
        } else if (btnName == "Wastelander" && IsCharacterPlayable(CharacterType.Wastelander)) {
            m_Controller.CharacterType = CharacterType.Wastelander;
            m_DevDisplay.SetActive(false);
            m_ToastedDisplay.SetActive(false);
            m_SmileyDisplay.SetActive(false);
            m_CowboyDisplay.SetActive(false);
            m_FootballDisplay.SetActive(false);
            m_TheBatDisplay.SetActive(false);
            m_VikingDisplay.SetActive(false);
            m_WastelanderDisplay.SetActive(true);
            m_SpaceSoldierDisplay.SetActive(false);
            m_SpeedsterDisplay.SetActive(false);
            m_HedgehogDisplay.SetActive(false);
            m_GoldFaceDisplay.SetActive(false);
        } else if (btnName == "SpaceSoldier" && IsCharacterPlayable(CharacterType.SpaceSoldier)) {
            m_Controller.CharacterType = CharacterType.SpaceSoldier;
            m_DevDisplay.SetActive(false);
            m_ToastedDisplay.SetActive(false);
            m_SmileyDisplay.SetActive(false);
            m_CowboyDisplay.SetActive(false);
            m_FootballDisplay.SetActive(false);
            m_TheBatDisplay.SetActive(false);
            m_VikingDisplay.SetActive(false);
            m_WastelanderDisplay.SetActive(false);
            m_SpaceSoldierDisplay.SetActive(true);
            m_SpeedsterDisplay.SetActive(false);
            m_HedgehogDisplay.SetActive(false);
            m_GoldFaceDisplay.SetActive(false);
        } else if (btnName == "Speedster" && IsCharacterPlayable(CharacterType.Speedster)) {
            m_Controller.CharacterType = CharacterType.Speedster;
            m_DevDisplay.SetActive(false);
            m_ToastedDisplay.SetActive(false);
            m_SmileyDisplay.SetActive(false);
            m_CowboyDisplay.SetActive(false);
            m_FootballDisplay.SetActive(false);
            m_TheBatDisplay.SetActive(false);
            m_VikingDisplay.SetActive(false);
            m_WastelanderDisplay.SetActive(false);
            m_SpaceSoldierDisplay.SetActive(false);
            m_SpeedsterDisplay.SetActive(true);
            m_HedgehogDisplay.SetActive(false);
            m_GoldFaceDisplay.SetActive(false);
        } else if (btnName == "Hedgehog" && IsCharacterPlayable(CharacterType.Hedgehog)) {
            m_Controller.CharacterType = CharacterType.Hedgehog;
            m_DevDisplay.SetActive(false);
            m_ToastedDisplay.SetActive(false);
            m_SmileyDisplay.SetActive(false);
            m_CowboyDisplay.SetActive(false);
            m_FootballDisplay.SetActive(false);
            m_TheBatDisplay.SetActive(false);
            m_VikingDisplay.SetActive(false);
            m_WastelanderDisplay.SetActive(false);
            m_SpaceSoldierDisplay.SetActive(false);
            m_SpeedsterDisplay.SetActive(false);
            m_HedgehogDisplay.SetActive(true);
            m_GoldFaceDisplay.SetActive(false);
        } else if (btnName == "GoldFace" && IsCharacterPlayable(CharacterType.GoldFace)) {
            m_Controller.CharacterType = CharacterType.GoldFace;
            m_DevDisplay.SetActive(false);
            m_ToastedDisplay.SetActive(false);
            m_SmileyDisplay.SetActive(false);
            m_CowboyDisplay.SetActive(false);
            m_FootballDisplay.SetActive(false);
            m_TheBatDisplay.SetActive(false);
            m_VikingDisplay.SetActive(false);
            m_WastelanderDisplay.SetActive(false);
            m_SpaceSoldierDisplay.SetActive(false);
            m_SpeedsterDisplay.SetActive(false);
            m_HedgehogDisplay.SetActive(false);
            m_GoldFaceDisplay.SetActive(true);
        }
    }

    private void InitCharPriceMap()
    {
        m_CharacterPriceMap = new Dictionary<CharacterType, int>();

        m_CharacterPriceMap[CharacterType.ToastedCharacter] = 0;
        m_CharacterPriceMap[CharacterType.DevCharacter] = 500;
        m_CharacterPriceMap[CharacterType.FootballPlayer] = 250;
        m_CharacterPriceMap[CharacterType.GoldFace] = 1000000;
        m_CharacterPriceMap[CharacterType.Hedgehog] = 8000;
        m_CharacterPriceMap[CharacterType.SmileyCharacter] = 100;
        m_CharacterPriceMap[CharacterType.SpaceCowboy] = 50;
        m_CharacterPriceMap[CharacterType.SpaceSoldier] = 3000;
        m_CharacterPriceMap[CharacterType.Speedster] = 6000;
        m_CharacterPriceMap[CharacterType.TheBat] = 1000;
        m_CharacterPriceMap[CharacterType.Viking] = 1500;
        m_CharacterPriceMap[CharacterType.Wastelander] = 2000;
    }

    private void UpdatePlayableCharMap()
    {
        int totalCoins = MasterController.GetInstance.TopCoinCount;

        if (totalCoins >= m_CharacterPriceMap[CharacterType.ToastedCharacter]) {
            m_PlayableCharacterMap[CharacterType.ToastedCharacter] = true;
        }

        if (totalCoins >= m_CharacterPriceMap[CharacterType.SpaceCowboy]) {
            m_PlayableCharacterMap[CharacterType.SpaceCowboy] = true;
        }

        if (totalCoins >= m_CharacterPriceMap[CharacterType.SmileyCharacter]) {
            m_PlayableCharacterMap[CharacterType.SmileyCharacter] = true;
        }

        if (totalCoins >= m_CharacterPriceMap[CharacterType.FootballPlayer]) {
            m_PlayableCharacterMap[CharacterType.FootballPlayer] = true;
        }

        if (totalCoins >= m_CharacterPriceMap[CharacterType.DevCharacter]) {
            m_PlayableCharacterMap[CharacterType.DevCharacter] = true;
        }

        if (totalCoins >= m_CharacterPriceMap[CharacterType.TheBat]) {
            m_PlayableCharacterMap[CharacterType.TheBat] = true;
        }

        if (totalCoins >= m_CharacterPriceMap[CharacterType.Viking]) {
            m_PlayableCharacterMap[CharacterType.Viking] = true;
        }

        if (totalCoins >= m_CharacterPriceMap[CharacterType.Wastelander]) {
            m_PlayableCharacterMap[CharacterType.Wastelander] = true;
        }

        if (totalCoins >= m_CharacterPriceMap[CharacterType.SpaceSoldier]) {
            m_PlayableCharacterMap[CharacterType.SpaceSoldier] = true;
        }

        if (totalCoins >= m_CharacterPriceMap[CharacterType.Speedster]) {
            m_PlayableCharacterMap[CharacterType.Speedster] = true;
        }

        if (totalCoins >= m_CharacterPriceMap[CharacterType.Hedgehog]) {
            m_PlayableCharacterMap[CharacterType.Hedgehog] = true;
        }

        if (totalCoins >= m_CharacterPriceMap[CharacterType.GoldFace]) {
            m_PlayableCharacterMap[CharacterType.GoldFace] = true;
        }

        
    }

    public void ShowPlayerSelect()
    { 

        UpdatePlayableCharMap();

        // TOGGLE
        m_PlayerPicker.SetActive(!m_PlayerPicker.activeSelf);

        m_AnnoyingUI.SetActive(!m_AnnoyingUI.activeSelf);

        m_AnnoyingUI2.SetActive(!m_AnnoyingUI2.activeSelf);

        m_AnnoyingUI3.SetActive(m_AnnoyingUI2.activeSelf);

        m_AnnoyingUI4.SetActive(!m_AnnoyingUI4.activeSelf);

        m_AnnoyingUI5.SetActive(!m_AnnoyingUI5.activeSelf);

       
    }

    //Player masks
    public GameObject m_SmileyMask;
    public GameObject m_DevMask;
    public GameObject m_CowboyMask;
    public GameObject m_FootballMask;
    public GameObject m_TheBatMask;
    public GameObject m_VikingMask;
    public GameObject m_WastelanderMask;
    public GameObject m_SpaceSoldierMask;
    public GameObject m_SpeedsterMask;
    public GameObject m_HedgehogMask;
    public GameObject m_GoldFaceMask;

    public void Update()
    {
        if (m_Controller == null) {
            m_Controller = MasterController.GetInstance;
        }

        if (Input.GetKeyDown(KeyCode.O)) {
            Debug.Log(m_Controller.CurrentScore);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
        }

        m_TopScoreText.SetText(m_Controller.TopScore.ToString());

        m_TopCoinCountText.SetText(m_Controller.TopCoinCount.ToString());

        int topCoinCount = int.Parse(m_TopCoinCountText.text);
        
        if (topCoinCount >=  m_CharacterPriceMap[CharacterType.SpaceCowboy]) {
            m_CowboyMask.SetActive(false);
            
        }
        if (topCoinCount >= m_CharacterPriceMap[CharacterType.SmileyCharacter]) {
            m_SmileyMask.SetActive(false);
            
        }

        if (topCoinCount >= m_CharacterPriceMap[CharacterType.FootballPlayer]) {
            m_FootballMask.SetActive(false);
            
        }
        if (topCoinCount >= m_CharacterPriceMap[CharacterType.DevCharacter]) {
            m_DevMask.SetActive(false);
            
        }
        if (topCoinCount >= m_CharacterPriceMap[CharacterType.TheBat]) {
            m_TheBatMask.SetActive(false);
            
        }
        if (topCoinCount >= m_CharacterPriceMap[CharacterType.Viking]) {
            m_VikingMask.SetActive(false);
            
        }
        if (topCoinCount >= m_CharacterPriceMap[CharacterType.Wastelander]) {
            m_WastelanderMask.SetActive(false);
            
        }
        if (topCoinCount >= m_CharacterPriceMap[CharacterType.SpaceSoldier]) {
            m_SpaceSoldierMask.SetActive(false);
            
        }
        if (topCoinCount >= m_CharacterPriceMap[CharacterType.Speedster]) {
            m_SpeedsterMask.SetActive(false);
            
        }
        if (topCoinCount >= m_CharacterPriceMap[CharacterType.Hedgehog]) {
            m_HedgehogMask.SetActive(false);
            
        }
        if (topCoinCount >= m_CharacterPriceMap[CharacterType.GoldFace]) {
            m_GoldFaceMask.SetActive(false);
            
        }

        // serialize data every frame
        MasterController.GetInstance.Serialize();
    }

}
