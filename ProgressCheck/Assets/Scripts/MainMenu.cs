using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int lives = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Dark");
        PlayerPrefs.SetInt("lives", lives);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Secret()
    {
        SceneManager.LoadScene("Secret");
    }
    public void Secret2()
    {
        SceneManager.LoadScene("Secret2");
    }
    public void Hardcore()
    {
        PlayerHP.hardcore = true;
        PlayerHP.health = 1;
        
        SceneManager.LoadScene("Dark");

    }
}
