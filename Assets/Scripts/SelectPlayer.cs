using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayer : MonoBehaviour
{
    private MasterController m_Controller;

    //Players
    public GameObject m_SmileyPlayer;
    public GameObject m_ToastedPlayer;
    public GameObject m_DevPlayer;
    public GameObject m_SpaceCowboy;
    public GameObject m_FootballPlayer;
    public GameObject m_TheBat;
    public GameObject m_Viking;
    public GameObject m_Wastelander;
    public GameObject m_SpaceSoldier;
    public GameObject m_Speedster;
    public GameObject m_Hedgehog;
    public GameObject m_GoldFace;


    public SceneController m_Scontrol;


    // Update is called once per frame
    void Update()
    {
        if (m_Controller == null) {
            m_Controller = MasterController.GetInstance;
        }
        
        if (m_Controller.m_CharacterType == CharacterType.DevCharacter) {
            m_DevPlayer.SetActive(true);
            m_SmileyPlayer.SetActive(false);
            m_ToastedPlayer.SetActive(false);
            m_SpaceCowboy.SetActive(false);
            m_FootballPlayer.SetActive(false);
            m_TheBat.SetActive(false);
            m_Viking.SetActive(false);
            m_Wastelander.SetActive(false);
            m_SpaceSoldier.SetActive(false);
            m_Speedster.SetActive(false);
            m_Hedgehog.SetActive(false);
            m_GoldFace.SetActive(false);
        } else if (m_Controller.m_CharacterType == CharacterType.SmileyCharacter) {
            m_DevPlayer.SetActive(false);
            m_SmileyPlayer.SetActive(true);
            m_ToastedPlayer.SetActive(false);
            m_SpaceCowboy.SetActive(false);
            m_FootballPlayer.SetActive(false);
            m_TheBat.SetActive(false);
            m_Viking.SetActive(false);
            m_Wastelander.SetActive(false);
            m_SpaceSoldier.SetActive(false);
            m_Speedster.SetActive(false);
            m_Hedgehog.SetActive(false);
            m_GoldFace.SetActive(false);
        } else if (m_Controller.m_CharacterType == CharacterType.ToastedCharacter) {
            m_DevPlayer.SetActive(false);
            m_SmileyPlayer.SetActive(false);
            m_ToastedPlayer.SetActive(true);
            m_SpaceCowboy.SetActive(false);
            m_FootballPlayer.SetActive(false);
            m_TheBat.SetActive(false);
            m_Viking.SetActive(false);
            m_Wastelander.SetActive(false);
            m_SpaceSoldier.SetActive(false);
            m_Speedster.SetActive(false);
            m_Hedgehog.SetActive(false);
            m_GoldFace.SetActive(false);
        } else if (m_Controller.m_CharacterType == CharacterType.SpaceCowboy) {
            m_DevPlayer.SetActive(false);
            m_SmileyPlayer.SetActive(false);
            m_ToastedPlayer.SetActive(false);
            m_SpaceCowboy.SetActive(true);
            m_FootballPlayer.SetActive(false);
            m_TheBat.SetActive(false);
            m_Viking.SetActive(false);
            m_Wastelander.SetActive(false);
            m_SpaceSoldier.SetActive(false);
            m_Speedster.SetActive(false);
            m_Hedgehog.SetActive(false);
            m_GoldFace.SetActive(false);
        } else if (m_Controller.m_CharacterType == CharacterType.FootballPlayer) {
            m_DevPlayer.SetActive(false);
            m_SmileyPlayer.SetActive(false);
            m_ToastedPlayer.SetActive(false);
            m_SpaceCowboy.SetActive(false);
            m_FootballPlayer.SetActive(true);
            m_TheBat.SetActive(false);
            m_Viking.SetActive(false);
            m_Wastelander.SetActive(false);
            m_SpaceSoldier.SetActive(false);
            m_Speedster.SetActive(false);
            m_Hedgehog.SetActive(false);
            m_GoldFace.SetActive(false);
        } else if (m_Controller.m_CharacterType == CharacterType.TheBat) {
            m_DevPlayer.SetActive(false);
            m_SmileyPlayer.SetActive(false);
            m_ToastedPlayer.SetActive(false);
            m_SpaceCowboy.SetActive(false);
            m_FootballPlayer.SetActive(false);
            m_TheBat.SetActive(true);
            m_Viking.SetActive(false);
            m_Wastelander.SetActive(false);
            m_SpaceSoldier.SetActive(false);
            m_Speedster.SetActive(false);
            m_Hedgehog.SetActive(false);
            m_GoldFace.SetActive(false);
        } else if (m_Controller.m_CharacterType == CharacterType.Viking) {
            m_DevPlayer.SetActive(false);
            m_SmileyPlayer.SetActive(false);
            m_ToastedPlayer.SetActive(false);
            m_SpaceCowboy.SetActive(false);
            m_FootballPlayer.SetActive(false);
            m_TheBat.SetActive(false);
            m_Viking.SetActive(true);
            m_Wastelander.SetActive(false);
            m_SpaceSoldier.SetActive(false);
            m_Speedster.SetActive(false);
            m_Hedgehog.SetActive(false);
            m_GoldFace.SetActive(false);
        } else if (m_Controller.m_CharacterType == CharacterType.Wastelander) {
            m_DevPlayer.SetActive(false);
            m_SmileyPlayer.SetActive(false);
            m_ToastedPlayer.SetActive(false);
            m_SpaceCowboy.SetActive(false);
            m_FootballPlayer.SetActive(false);
            m_TheBat.SetActive(false);
            m_Viking.SetActive(false);
            m_Wastelander.SetActive(true);
            m_SpaceSoldier.SetActive(false);
            m_Speedster.SetActive(false);
            m_Hedgehog.SetActive(false);
            m_GoldFace.SetActive(false);
        } else if (m_Controller.m_CharacterType == CharacterType.SpaceSoldier) {
            m_DevPlayer.SetActive(false);
            m_SmileyPlayer.SetActive(false);
            m_ToastedPlayer.SetActive(false);
            m_SpaceCowboy.SetActive(false);
            m_FootballPlayer.SetActive(false);
            m_TheBat.SetActive(false);
            m_Viking.SetActive(false);
            m_Wastelander.SetActive(false);
            m_SpaceSoldier.SetActive(true);
            m_Speedster.SetActive(false);
            m_Hedgehog.SetActive(false);
            m_GoldFace.SetActive(false);
        } else if (m_Controller.m_CharacterType == CharacterType.Speedster) {
            m_DevPlayer.SetActive(false);
            m_SmileyPlayer.SetActive(false);
            m_ToastedPlayer.SetActive(false);
            m_SpaceCowboy.SetActive(false);
            m_FootballPlayer.SetActive(false);
            m_TheBat.SetActive(false);
            m_Viking.SetActive(false);
            m_Wastelander.SetActive(false);
            m_SpaceSoldier.SetActive(false);
            m_Speedster.SetActive(true);
            m_Hedgehog.SetActive(false);
            m_GoldFace.SetActive(false);
        } else if (m_Controller.m_CharacterType == CharacterType.Hedgehog) {
            m_DevPlayer.SetActive(false);
            m_SmileyPlayer.SetActive(false);
            m_ToastedPlayer.SetActive(false);
            m_SpaceCowboy.SetActive(false);
            m_FootballPlayer.SetActive(false);
            m_TheBat.SetActive(false);
            m_Viking.SetActive(false);
            m_Wastelander.SetActive(false);
            m_SpaceSoldier.SetActive(false);
            m_Speedster.SetActive(false);
            m_Hedgehog.SetActive(true);
            m_GoldFace.SetActive(false);
        } else if (m_Controller.m_CharacterType == CharacterType.GoldFace) {
            m_DevPlayer.SetActive(false);
            m_SmileyPlayer.SetActive(false);
            m_ToastedPlayer.SetActive(false);
            m_SpaceCowboy.SetActive(false);
            m_FootballPlayer.SetActive(false);
            m_TheBat.SetActive(false);
            m_Viking.SetActive(false);
            m_Wastelander.SetActive(false);
            m_SpaceSoldier.SetActive(false);
            m_Speedster.SetActive(false);
            m_Hedgehog.SetActive(false);
            m_GoldFace.SetActive(true);
        }




        //Masks

        if (m_Controller.m_CharacterType == CharacterType.SpaceCowboy) {
            m_Scontrol.m_DevMask.SetActive(true);
            m_Scontrol.m_SmileyMask.SetActive(true);
            m_Scontrol.m_CowboyMask.SetActive(false);
            m_Scontrol.m_FootballMask.SetActive(true);
            m_Scontrol.m_TheBatMask.SetActive(true);
            m_Scontrol.m_VikingMask.SetActive(true);
            m_Scontrol.m_WastelanderMask.SetActive(true);
            m_Scontrol.m_SpaceSoldierMask.SetActive(true);
            m_Scontrol.m_SpeedsterMask.SetActive(true);
            m_Scontrol.m_HedgehogMask.SetActive(true);
            m_Scontrol.m_GoldFaceMask.SetActive(true);
        } else if (m_Controller.m_CharacterType == CharacterType.SmileyCharacter) {
            m_Scontrol.m_DevMask.SetActive(true);
            m_Scontrol.m_SmileyMask.SetActive(false);
            m_Scontrol.m_CowboyMask.SetActive(true);
            m_Scontrol.m_FootballMask.SetActive(true);
            m_Scontrol.m_TheBatMask.SetActive(true);
            m_Scontrol.m_VikingMask.SetActive(true);
            m_Scontrol.m_WastelanderMask.SetActive(true);
            m_Scontrol.m_SpaceSoldierMask.SetActive(true);
            m_Scontrol.m_SpeedsterMask.SetActive(true);
            m_Scontrol.m_HedgehogMask.SetActive(true);
            m_Scontrol.m_GoldFaceMask.SetActive(true);
        } else if (m_Controller.m_CharacterType == CharacterType.DevCharacter) {
            m_Scontrol.m_DevMask.SetActive(false);
            m_Scontrol.m_SmileyMask.SetActive(true);
            m_Scontrol.m_CowboyMask.SetActive(true);
            m_Scontrol.m_FootballMask.SetActive(true);
            m_Scontrol.m_TheBatMask.SetActive(true);
            m_Scontrol.m_VikingMask.SetActive(true);
            m_Scontrol.m_WastelanderMask.SetActive(true);
            m_Scontrol.m_SpaceSoldierMask.SetActive(true);
            m_Scontrol.m_SpeedsterMask.SetActive(true);
            m_Scontrol.m_HedgehogMask.SetActive(true);
            m_Scontrol.m_GoldFaceMask.SetActive(true);
        } else if (m_Controller.m_CharacterType == CharacterType.FootballPlayer) {
            m_Scontrol.m_DevMask.SetActive(true);
            m_Scontrol.m_SmileyMask.SetActive(true);
            m_Scontrol.m_CowboyMask.SetActive(true);
            m_Scontrol.m_FootballMask.SetActive(false);
            m_Scontrol.m_TheBatMask.SetActive(true);
            m_Scontrol.m_VikingMask.SetActive(true);
            m_Scontrol.m_WastelanderMask.SetActive(true);
            m_Scontrol.m_SpaceSoldierMask.SetActive(true);
            m_Scontrol.m_SpeedsterMask.SetActive(true);
            m_Scontrol.m_HedgehogMask.SetActive(true);
            m_Scontrol.m_GoldFaceMask.SetActive(true);
        } else if (m_Controller.m_CharacterType == CharacterType.TheBat) {
            m_Scontrol.m_DevMask.SetActive(true);
            m_Scontrol.m_SmileyMask.SetActive(true);
            m_Scontrol.m_CowboyMask.SetActive(true);
            m_Scontrol.m_FootballMask.SetActive(true);
            m_Scontrol.m_TheBatMask.SetActive(false);
            m_Scontrol.m_VikingMask.SetActive(true);
            m_Scontrol.m_WastelanderMask.SetActive(true);
            m_Scontrol.m_SpaceSoldierMask.SetActive(true);
            m_Scontrol.m_SpeedsterMask.SetActive(true);
            m_Scontrol.m_HedgehogMask.SetActive(true);
            m_Scontrol.m_GoldFaceMask.SetActive(true);
        } else if (m_Controller.m_CharacterType == CharacterType.Viking) {
            m_Scontrol.m_DevMask.SetActive(true);
            m_Scontrol.m_SmileyMask.SetActive(true);
            m_Scontrol.m_CowboyMask.SetActive(true);
            m_Scontrol.m_FootballMask.SetActive(true);
            m_Scontrol.m_TheBatMask.SetActive(true);
            m_Scontrol.m_VikingMask.SetActive(false);
            m_Scontrol.m_WastelanderMask.SetActive(true);
            m_Scontrol.m_SpaceSoldierMask.SetActive(true);
            m_Scontrol.m_SpeedsterMask.SetActive(true);
            m_Scontrol.m_HedgehogMask.SetActive(true);
            m_Scontrol.m_GoldFaceMask.SetActive(true);
        } else if (m_Controller.m_CharacterType == CharacterType.Wastelander) {
            m_Scontrol.m_DevMask.SetActive(true);
            m_Scontrol.m_SmileyMask.SetActive(true);
            m_Scontrol.m_CowboyMask.SetActive(true);
            m_Scontrol.m_FootballMask.SetActive(true);
            m_Scontrol.m_TheBatMask.SetActive(true);
            m_Scontrol.m_VikingMask.SetActive(true);
            m_Scontrol.m_WastelanderMask.SetActive(false);
            m_Scontrol.m_SpaceSoldierMask.SetActive(true);
            m_Scontrol.m_SpeedsterMask.SetActive(true);
            m_Scontrol.m_HedgehogMask.SetActive(true);
            m_Scontrol.m_GoldFaceMask.SetActive(true);
        } else if (m_Controller.m_CharacterType == CharacterType.SpaceSoldier) {
            m_Scontrol.m_DevMask.SetActive(true);
            m_Scontrol.m_SmileyMask.SetActive(true);
            m_Scontrol.m_CowboyMask.SetActive(true);
            m_Scontrol.m_FootballMask.SetActive(true);
            m_Scontrol.m_TheBatMask.SetActive(true);
            m_Scontrol.m_VikingMask.SetActive(true);
            m_Scontrol.m_WastelanderMask.SetActive(true);
            m_Scontrol.m_SpaceSoldierMask.SetActive(false);
            m_Scontrol.m_SpeedsterMask.SetActive(true);
            m_Scontrol.m_HedgehogMask.SetActive(true);
            m_Scontrol.m_GoldFaceMask.SetActive(true);
        } else if (m_Controller.m_CharacterType == CharacterType.Speedster) {
            m_Scontrol.m_DevMask.SetActive(true);
            m_Scontrol.m_SmileyMask.SetActive(true);
            m_Scontrol.m_CowboyMask.SetActive(true);
            m_Scontrol.m_FootballMask.SetActive(true);
            m_Scontrol.m_TheBatMask.SetActive(true);
            m_Scontrol.m_VikingMask.SetActive(true);
            m_Scontrol.m_WastelanderMask.SetActive(true);
            m_Scontrol.m_SpaceSoldierMask.SetActive(true);
            m_Scontrol.m_SpeedsterMask.SetActive(false);
            m_Scontrol.m_HedgehogMask.SetActive(true);
            m_Scontrol.m_GoldFaceMask.SetActive(true);
        } else if (m_Controller.m_CharacterType == CharacterType.Hedgehog) {
            m_Scontrol.m_DevMask.SetActive(true);
            m_Scontrol.m_SmileyMask.SetActive(true);
            m_Scontrol.m_CowboyMask.SetActive(true);
            m_Scontrol.m_FootballMask.SetActive(true);
            m_Scontrol.m_TheBatMask.SetActive(true);
            m_Scontrol.m_VikingMask.SetActive(true);
            m_Scontrol.m_WastelanderMask.SetActive(true);
            m_Scontrol.m_SpaceSoldierMask.SetActive(true);
            m_Scontrol.m_SpeedsterMask.SetActive(true);
            m_Scontrol.m_HedgehogMask.SetActive(false);
            m_Scontrol.m_GoldFaceMask.SetActive(true);
        } else if (m_Controller.m_CharacterType == CharacterType.GoldFace) {
            m_Scontrol.m_DevMask.SetActive(true);
            m_Scontrol.m_SmileyMask.SetActive(true);
            m_Scontrol.m_CowboyMask.SetActive(true);
            m_Scontrol.m_FootballMask.SetActive(true);
            m_Scontrol.m_TheBatMask.SetActive(true);
            m_Scontrol.m_VikingMask.SetActive(true);
            m_Scontrol.m_WastelanderMask.SetActive(true);
            m_Scontrol.m_SpaceSoldierMask.SetActive(true);
            m_Scontrol.m_SpeedsterMask.SetActive(true);
            m_Scontrol.m_HedgehogMask.SetActive(true);
            m_Scontrol.m_GoldFaceMask.SetActive(false);
        }

        
    }
}
