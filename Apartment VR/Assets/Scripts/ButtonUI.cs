using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{

    [SerializeField] private string newGameLevel = "Apartment";
    [SerializeField] private Canvas m_Menu;
    [SerializeField] private Canvas i_Menu;

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void Info()
    {
        m_Menu.enabled = false;
        i_Menu.enabled = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Understand()
    {
        m_Menu.enabled = true;
        i_Menu.enabled = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
