using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApartmentButtonUI : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Main Menu";

    public void QuitToMain()
    {
        SceneManager.LoadScene(newGameLevel);
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
