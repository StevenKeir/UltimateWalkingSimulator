using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Achievement : MonoBehaviour
{

    public PlayerMovement myMovement;
    public FadeText fadeScript;
    public AudioSource achievementSound;
    public AudioSource finalAchievementSound;
    public AudioSource HouseDoorSound;
    public AudioSource ShopDoor;

    public string[] achievementText = new string[18];
    public string currentAchievement;

    public TMP_Text printAchievement;
    public GameObject textBox;

    public int amountOfAchievements;
    public int runOnce = 0;
    public int exControl = 0;
    public float clock;
    public string exclamation;
    public float timer;
    public float wait;

    public bool hitFloor;
    public bool hitDoor;
    public bool hitShop;
    public bool hitCar;
    public bool hitBed;
    public bool hitFridge;
    public bool hitLight;
    public bool checkMove;
    public bool checkJump;
    public bool hitBread;
    public bool madeSandwitch;
    public bool finishGame;
    public int shopKeeper;


    // Use this for initialization
    void Start()
    {
        clock = 0;
        shopKeeper = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ListOfAchievements();
        Timer();
        ClockAchievements();


        if (myMovement.haveJumped == true && checkJump == false)
        {
            currentAchievement = achievementText[3];
            AchievementGained();
            checkJump = true;
            myMovement.jumpedOnce = true;
        }

        if (Input.GetKeyDown("g"))
        {
            SceneManager.LoadScene("MovementTweak");
        }
        if (finishGame == true)
        {
            FinishGame();
        }
    }

    void ExclamationMultiplyer()
    { 
        if (amountOfAchievements == 0)
        {
            exclamation = "!";
        }
        if (amountOfAchievements == 1)
        {
            exclamation = "!!";
        }
        if (amountOfAchievements == 2)
        {
            exclamation = "!!!";
        }
        if (amountOfAchievements == 3)
        {
            exclamation = "!!!!";
        }
        if (amountOfAchievements == 4)
        {
            exclamation = "!!!!!";
        }
        if (amountOfAchievements == 5)
        {
            exclamation = "!!!!!!";
        }
        if (amountOfAchievements == 6)
        {
            exclamation = "!!!!!!!";
        }
        if (amountOfAchievements == 7)
        {
            exclamation = "!!!!!!!!";
        }
        if (amountOfAchievements == 8)
        {
            exclamation = "!!!!!!!!!";
        }
        if (amountOfAchievements == 9)
        {
            exclamation = "!!!!!!!!!!";
        }
        if (amountOfAchievements == 10)
        {
            exclamation = "!!!!!!!!!!!";
        }
        if (amountOfAchievements == 11)
        {
            exclamation = "!!!!!!!!!!!!";
        }
        if (amountOfAchievements == 12)
        {
            exclamation = "!!!!!!!!!!!!!";
        }
        if (amountOfAchievements == 13)
        {
            exclamation = "!!!!!!!!!!!!!!";
        }
        if (amountOfAchievements == 14)
        {
            exclamation = "!!!!!!!!!!!!!!!";
        }
        if (amountOfAchievements == 15)
        {
            exclamation = "!!!!!!!!!!!!!!!!";
        }
        if (amountOfAchievements == 16)
        {
            exclamation = "!!!!!!!!!!!!!!!!!";
        }


    }

    void Timer()
    {
        clock += Time.deltaTime;
    }

    void ClockAchievements()
    {
        if (clock >= 45 && runOnce == 2)
        {
            runOnce++;
            currentAchievement = achievementText[8];
            AchievementGained();
        }
        else if (clock >= 30 && runOnce == 1)
        {
            runOnce++;
            currentAchievement = achievementText[7];
            AchievementGained();
        }
        else if (clock >= 15 && runOnce == 0)
        {
            runOnce++;
            currentAchievement = achievementText[6];
            AchievementGained();
        }
    }

    void AchievementGained()
    {

        ExclamationMultiplyer();
        printAchievement.text = "ACHIEVEMENT UNLOCKED!!! " + currentAchievement + exclamation;
        if (madeSandwitch != true)
        {
            achievementSound.Play();
            amountOfAchievements++;
        }
        else
        {
            finalAchievementSound.Play();
            finishGame = true;
        }
        myMovement.canMove = false;

        fadeScript.fadingIn = true;
        
    }

    void FinishGame ()
    {
        timer += Time.deltaTime;
        wait = 2f;
        if (timer >= wait)
        {
            ExclamationMultiplyer();
            printAchievement.text = "YOU FINISHED THE GAME!!! IF YOU WOULD LIKE TO PLAY AGAIN PRESS G" + exclamation;
            myMovement.canMove = false;
            fadeScript.fadingIn = true;
        }
    }


    void ListOfAchievements()
    {

        achievementText[0] = "YOU STARTED THE GAME";
        achievementText[1] = "YOU GOT OUT OF BED";
        achievementText[2] = "YOU HAVE NO BREAD, GO TO THE SHOPS";
        achievementText[3] = "YOU JUMPED";
        achievementText[4] = "YOU OPENED THE DOOR";
        achievementText[5] = "YOU MADE IT TO THE SHOP";
        achievementText[6] = "YOU PLAYED THE GAME FOR 15 SECONDS";
        achievementText[7] = "YOU PLAYED THE GAME FOR 30 SECONDS";
        achievementText[8] = "YOU PLAYED THE GAME FOR 45 SECONDS";
        achievementText[9] = "THAT WILL BE $2.40, YOU PURCHASED BREAD";
        achievementText[10] = "YOU GOT HIT BY A CAR";
        achievementText[11] = "YOU JAYWALKED";
        achievementText[12] = "YOU GOT HOME WITH THE BREAD";
        achievementText[13] = "YOU COMPLETED THE GAME";
        achievementText[14] = "YOU PICKED UP THE BREAD";
        achievementText[15] = "YOU DIDN'T JAYWALK";
        achievementText[16] = "YOU MADE A SANDWITCH";
        achievementText[17] = "IF YOU WOULD LIKE TO BUY BREAD, PLEASE BRING IT TO THE COUNTER";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground" && hitFloor == false)
        {
            currentAchievement = achievementText[1];
            AchievementGained();
            hitFloor = true;
        }
        if (collision.gameObject.tag == "Bed" && hitFridge == false)
        {
            currentAchievement = achievementText[0];
            AchievementGained();
            hitBed = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Door")
        {
            if (hitBread == false)
            {
                currentAchievement = achievementText[4];
                AchievementGained();
                HouseDoorSound.Play();
            }
            else if (hitBread == true)
            {
                currentAchievement = achievementText[12];
                AchievementGained();
                HouseDoorSound.Play();
            }
        }

        if (col.gameObject.tag == "Shop" && hitShop == false)
        {
            currentAchievement = achievementText[5];
            AchievementGained();
            ShopDoor.Play();
            hitShop = true;
        }

        if (col.gameObject.tag == "Car" && hitCar == false)
        {
            currentAchievement = achievementText[10];
            AchievementGained();
            hitCar = true;
        }

        if (col.gameObject.tag == "Fridge" && hitFridge == false)
        {
            currentAchievement = achievementText[2];
            AchievementGained();
            hitFridge = true;
        }

        if (col.gameObject.tag == "TrafficLight" && hitLight == false)
        {
            currentAchievement = achievementText[11];
            AchievementGained();
            hitLight = true;
        }

        if (col.gameObject.tag == "Breed" && hitBread == false)
        {
            currentAchievement = achievementText[14];
            AchievementGained();
            hitBread = true;
        }

        if (col.gameObject.tag == "ShopKeep")
        {
            if (shopKeeper == 0)
            {
                currentAchievement = achievementText[17];
                AchievementGained();
                shopKeeper++;
            }
            if (shopKeeper == 1 && hitBread == true)
            {
                currentAchievement = achievementText[9];
                AchievementGained();
                shopKeeper++;
            }
        }

        if (col.gameObject.tag == "CupBoard" && hitBread == true)
        {
            currentAchievement = achievementText[16];
            madeSandwitch = true;
            AchievementGained();

        }
    }



}
