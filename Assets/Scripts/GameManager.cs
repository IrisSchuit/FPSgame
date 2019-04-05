using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private string sceneName;
    private SoundManager soundManager;
    private Door door;
    private EndUI endUI;
    public Text colorPoints;
    public Text endPoints;

    private void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        sceneName = currentScene.name;

        soundManager = GetComponent<SoundManager>();

        endUI = FindObjectOfType<EndUI>();

        door = FindObjectOfType<Door>();
    }

    private void Update()
    {
        if (sceneName == "StartScherm")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                soundManager.PlayAudio(0);
                SceneManager.LoadScene("Level1");
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }

        if (sceneName == "Level1")
        {
            if(door.amount < door.totalAmount)
            {
                colorPoints.enabled = true;
                endPoints.enabled = false;
            }
            else if(door.amount >= door.totalAmount)
            {
                colorPoints.enabled = false;
                endPoints.enabled = true;
            }
            colorPoints.text = door.amount + " / " + door.totalAmount;

            endPoints.text = endUI.amount + " / " + endUI.totalAmount;
        }

        if (sceneName == "EindScherm")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("StartScherm");
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }

    }
}