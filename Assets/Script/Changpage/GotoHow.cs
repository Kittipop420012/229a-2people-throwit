using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GotoHow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Button GameHin;

    void Start()
    {
        GameHin.onClick.AddListener(Gotohow);
    }

    // Update is called once per frame
    void Gotohow()
    {
        SceneManager.LoadScene("Howtoplay");  
    }
}