using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuPlayButton : MonoBehaviour
{
    private Button _playButton;

    private void Start()
    {
        _playButton = GetComponent<Button>();
        _playButton.onClick.AddListener(PlayGame);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
}