using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAutoLoade : MonoBehaviour
{
    public string SceneName;

    private void Awake()
    {
        if (!string.IsNullOrEmpty(SceneName))
            SceneManager.LoadScene(SceneName);
    }
}
