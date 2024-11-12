using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Button button1; // Button to load Scene 1
    public Button button2; // Button to load Scene 2
    public Button button3; // Button to load Scene 3
    public Button backButton; // Back button to return to Scene 0

    private void Start()
    {
        // Assign listeners for Scene 0 buttons, if present
        if (button1 != null)
        {
            button1.onClick.AddListener(() => LoadScene(1)); // Load Scene 1
        }

        if (button2 != null)
        {
            button2.onClick.AddListener(() => LoadScene(2)); // Load Scene 2
        }

        if (button3 != null)
        {
            button3.onClick.AddListener(() => LoadScene(3)); // Load Scene 3
        }

        // Assign listener for back button if it exists (only in Scenes 1, 2, and 3)
        if (backButton != null)
        {
            backButton.onClick.AddListener(LoadMainMenu); // Load Scene 0
        }
    }

    private void LoadScene(int sceneIndex)
    {
        Debug.Log("Loading Scene " + sceneIndex);
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
    }

    private void LoadMainMenu()
    {
        Debug.Log("Returning to Main Menu (Scene 0)");
        SceneManager.LoadScene(0);
    }
}
