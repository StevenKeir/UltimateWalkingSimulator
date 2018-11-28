using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Achievement : MonoBehaviour {

    public PlayerMovement myMovement;
    public AudioSource achievementSound;

    public string[] achievementText = new string[14];
    public string currentAchievement;

    public TMP_Text printAchievement;
    public GameObject textBox;

    public int amountOfAchievements;
    public int runOnce = 0;
    public float clock;
    public string exclamation;

    public bool hitFloor;
    public bool hitDoor;
    public bool hitShop;
    public bool hitCar;
    public bool checkMove;
    public bool checkJump;

    // Use this for initialization
    void Start () {

        currentAchievement = achievementText[0];
        AchievementGained();
        clock = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        ListOfAchievements();
        Timer();
        ClockAchievements();

        if (myMovement.haveMoved == true && checkMove == false)
        {
            currentAchievement = achievementText[2];
            AchievementGained();
            checkMove = true;
        }

        if (myMovement.haveJumped == true && checkJump == false)
        { 
            currentAchievement = achievementText[3];
            AchievementGained();
            checkJump = true;
        }

    }

    void ExclamationMultiplyer ()
    {

        for (int i = 0; i < amountOfAchievements; i++)
        {
            exclamation = "!";
        }

    }

    void Timer ()
    {
        clock += Time.deltaTime;
    }

    void ClockAchievements ()
    {
        if (clock >= 120 && runOnce == 2)
        {
            runOnce++;
            currentAchievement = achievementText[8];
            AchievementGained();
        }
        else if (clock >= 60 && runOnce == 1)
        {
            runOnce++;
            currentAchievement = achievementText[7];
            AchievementGained();
        }
        else if (clock >= 10 && runOnce == 0)
        {
            runOnce++;
            currentAchievement = achievementText[6];
            AchievementGained();
        }
    }

    void AchievementGained ()
    {

        ExclamationMultiplyer();
        printAchievement.text = "ACHIEVEMENT UNLOCKED!!! " + currentAchievement + exclamation;
        //achievementSound.Play();
        amountOfAchievements++;
    }

    void ListOfAchievements()
    {

        achievementText[0] = "YOU STARTED THE GAME";
        achievementText[1] = "YOU GOT OUT OF BED";
        achievementText[2] = "YOUR WALKING";
        achievementText[3] = "YOU JUMPED";
        achievementText[4] = "YOU OPEND THE DOOR";
        achievementText[5] = "YOU MADE IT TO THE SHOP";
        achievementText[6] = "YOU PLAYED THE GAME FOR 10SECONDS";
        achievementText[7] = "YOU PLAYED THE GAME FOR 1MINUTE";
        achievementText[8] = "YOU PLAYED THE GAME FOR 2MINUTE";
        achievementText[9] = "YOU PURCHASED BREAD";
        achievementText[10] = "YOU GOT HIT BY A CAR";
        achievementText[11] = "YOU JAYWALKED";
        achievementText[12] = "YOU GOT HOME WITH THE BREAD";
        achievementText[13] = "YOU COMPLETED THE GAME";

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground" && hitFloor == false)
        {
            currentAchievement = achievementText[1];
            AchievementGained();
            hitFloor = true;
        }

    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Door" && hitDoor == false)
        {
            currentAchievement = achievementText[4];
            AchievementGained();
            hitDoor = true;
        }
        if (col.gameObject.tag == "Shop" && hitShop == false)
        {
            currentAchievement = achievementText[5];
            AchievementGained();
            hitShop = true;
        }
        if (col.gameObject.tag == "Car" && hitCar == false)
        {
            currentAchievement = achievementText[10];
            AchievementGained();
            hitCar = true;
        }
    }



}
