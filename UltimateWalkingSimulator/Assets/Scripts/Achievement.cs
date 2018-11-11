using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievement : MonoBehaviour {

    public string[] achievementText = new string[14];
    public Text printAchievement;
    public GameObject textBox;
    public int amountOfAchievements;
    public string exclamation;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        ListOfAchievements();
   
    }

    void ExclamationMultiplyer ()
    {

        for (int i = 0; i < amountOfAchievements; i++)
        {
            exclamation = "!";
        }

    }

    void AchievementGained ()
    {

        ExclamationMultiplyer();
        printAchievement.text = "ACHIEVEMENT UNLOCKED!!! " + achievementText + exclamation;
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
        achievementText[12] = "YOU COMPLETED THE GAME";

    }

}
