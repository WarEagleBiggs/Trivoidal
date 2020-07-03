using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;

public class SceneController : MonoBehaviour
{

    private MasterController m_Controller;

    public GameObject m_PlayerPicker;

    public GameObject m_AnnoyingUI;

    public GameObject m_AnnoyingUI2;

    public TMP_Text m_TopScoreText;

    public TMP_Text m_TopCoinCountText;

    
    
    // associative map of character name and whether playable
    private Dictionary<CharacterType, bool> m_PlayableCharacterMap;

    // associative map of character name and price to buy
    private Dictionary<CharacterType, int> m_CharacterPriceMap;

    public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

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
        if (m_PlayableCharacterMap == null) {
            InitPlayerCharMap();
        }

        if (m_CharacterPriceMap == null) {
            InitCharPriceMap();
        }
    }
    

    public void OnPlayerSelectButton()
    {
        

        string btnName = EventSystem.current.currentSelectedGameObject.name;

        if (btnName == "DevPlayer" && IsCharacterPlayable(CharacterType.DevCharacter)) {
            m_Controller.m_CharacterType = CharacterType.DevCharacter;
        } else if (btnName == "ToastedPlayer" && IsCharacterPlayable(CharacterType.ToastedCharacter)) {
            m_Controller.m_CharacterType = CharacterType.ToastedCharacter;
        } else if (btnName == "SmileyPlayer" && IsCharacterPlayable(CharacterType.SmileyCharacter)) {
            m_Controller.m_CharacterType = CharacterType.SmileyCharacter;
        } else if (btnName == "SpaceCowboy" && IsCharacterPlayable(CharacterType.SpaceCowboy)) {
            m_Controller.m_CharacterType = CharacterType.SpaceCowboy;
        } else if (btnName == "FootballPlayer" && IsCharacterPlayable(CharacterType.FootballPlayer)) {
            m_Controller.m_CharacterType = CharacterType.FootballPlayer;
        } else if (btnName == "TheBat" && IsCharacterPlayable(CharacterType.TheBat)) {
            m_Controller.m_CharacterType = CharacterType.TheBat;
        } else if (btnName == "Viking" && IsCharacterPlayable(CharacterType.Viking)) {
            m_Controller.m_CharacterType = CharacterType.Viking;
        } else if (btnName == "Wastelander" && IsCharacterPlayable(CharacterType.Wastelander)) {
            m_Controller.m_CharacterType = CharacterType.Wastelander;
        } else if (btnName == "SpaceSoldier" && IsCharacterPlayable(CharacterType.SpaceSoldier)) {
            m_Controller.m_CharacterType = CharacterType.SpaceSoldier;
        } else if (btnName == "Speedster" && IsCharacterPlayable(CharacterType.Speedster)) {
            m_Controller.m_CharacterType = CharacterType.Speedster;
        } else if (btnName == "Hedgehog" && IsCharacterPlayable(CharacterType.Hedgehog)) {
            m_Controller.m_CharacterType = CharacterType.Hedgehog;
        } else if (btnName == "GoldFace" && IsCharacterPlayable(CharacterType.GoldFace)) {
            m_Controller.m_CharacterType = CharacterType.GoldFace;
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
        int totalCoins = MasterController.GetInstance.m_TopCoinCount;

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


        

        m_TopScoreText.SetText(m_Controller.m_TopScore.ToString());

        m_TopCoinCountText.SetText(m_Controller.m_TopCoinCount.ToString());

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
        
        

    }

}
