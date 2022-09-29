using UnityEngine;
using UnityEngine.SceneManagement;
using Scenes;

public class LoseScene : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene(((byte)Scenes.ScenesEnum.MainMenu));
    }
}
