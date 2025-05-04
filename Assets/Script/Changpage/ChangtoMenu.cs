using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ChangtoMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Button tomenu;

    void Start()
    {
        tomenu.onClick.AddListener(GotoMenu);
    }

    // Update is called once per frame
    void GotoMenu()
    {
        SceneManager.LoadScene("Menu");  
    }
}