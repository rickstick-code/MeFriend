using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartApplication : MonoBehaviour
{
    private void Awake()
    {
        SaveAndLoadHandler.LoadOrCreate();

        if (SaveAndLoadHandler.State.SelectedPet == default)
        {
            SceneManager.LoadScene("PetSelection");
        }
        else
        {
            SceneManager.LoadScene("MainRoom");
        }       
    }
}
