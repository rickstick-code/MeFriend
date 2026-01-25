using UnityEngine;

public class InitializeAnimal : MonoBehaviour
{
    void Start()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(child.name == SaveAndLoadHandler.State.SelectedPet.ToString());
        }
    }
}
