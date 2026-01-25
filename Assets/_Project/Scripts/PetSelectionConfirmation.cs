using UnityEngine;
using UnityEngine.SceneManagement;

public class PetSelectionConfirmation : MonoBehaviour
{
    public PetType PetType;

    public void ConfirmSelection()
    {
        SaveAndLoadHandler.State.SelectedPet = PetType;
        SceneManager.LoadScene("MainRoom");
    }

    public void CancelSelection()
    {
        SaveAndLoadHandler.State.SelectedPet = PetType.None;
        GameObject.Find("ConfirmationWindow").SetActive(false);
    }
}
