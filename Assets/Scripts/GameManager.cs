using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("No Game Manager is in Game");
            }
            return _instance;
        }
    }

    [SerializeField]
    private GameObject DirectionalLight,FlashLight,OfficeLights,ExitLight,Bloodsplatter,OfficeRound0,OfficeRound1,HospitalRound0,HospitalRound1,HopsitalRound2,OfficeRound2,OfficeRound3,HospitalRound3;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        FlashLight.SetActive(false);
        ExitLight.SetActive(false);
        OfficeLights.SetActive(false);
        Bloodsplatter.SetActive(false);
        OfficeRound1.SetActive(false);
        HospitalRound1.SetActive(false);
        HopsitalRound2.SetActive(false);
        OfficeRound2.SetActive(false);
        OfficeRound3.SetActive(false);
        HospitalRound3.SetActive(false);
    }

    private void Update()
    {
        RoundsEvents();
    }

    public bool HasKey { get; set; }
    public int TotalRounds;

    public void TotalRoundsCounter()
    {
        TotalRounds++;
    }

    public void RoundsEvents()
    {
        switch(TotalRounds)
        {
            case 1:
                if(TotalRounds == 1)
                {
                    DirectionalLight.SetActive(false);
                    ExitLight.SetActive(true);
                    FlashLight.SetActive(true);
                    OfficeLights.SetActive(true);
                    Bloodsplatter.SetActive(true);
                    OfficeRound0.SetActive(false);
                    OfficeRound1.SetActive(true);
                    HospitalRound0.SetActive(false);
                    HospitalRound1.SetActive(true);
                }
                break;
            case 2:
                if(TotalRounds == 2)
                {
                    HospitalRound1.SetActive(false);
                    HopsitalRound2.SetActive(true);
                    OfficeRound1.SetActive(false);
                    OfficeRound2.SetActive(true);
                }
                break;
            case 3:
                if(TotalRounds == 3)
                {
                    OfficeRound2.SetActive(false);
                    OfficeRound3.SetActive(true);
                    HopsitalRound2.SetActive(false);
                    HospitalRound3.SetActive(true);
                }
                break;
            case 4:
                if(TotalRounds == 4)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
                break;
            default:
                break;
        }
    }


}
