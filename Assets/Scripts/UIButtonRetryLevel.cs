using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonRetryLevel : MonoBehaviour //Attached to the buttons on the Level Finish scene
{
    [SerializeField] private CurrentLevelInfo currentLevelInfo; //SO containing the info about the current level progress
    public void Retry() //When retry button is pressed
    {
        Time.timeScale = 1f;
        // Resets current progress
        currentLevelInfo.currentLevelScore = 0;
        currentLevelInfo.bouquetsShipped = 0;
        currentLevelInfo.bouquetsShippedRibbon = 0;
        SceneManager.LoadScene(currentLevelInfo.currentLevel); //Loads current level again
    }
    public void Menu() //When menu button is pressed
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0); //Loads main menu scene
    }

    public void NextLevel() //When next level button is pressed
    {
        Time.timeScale = 1f;
        currentLevelInfo.currentLevel = 2; //Changes current level in the game memory to level 2
        // Resets current progress
        currentLevelInfo.currentLevelScore = 0;
        currentLevelInfo.bouquetsShipped = 0;
        currentLevelInfo.bouquetsShippedRibbon = 0;
        SceneManager.LoadScene(currentLevelInfo.currentLevel); //Loads current level again
    }
}
