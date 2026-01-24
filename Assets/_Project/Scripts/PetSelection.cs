using System.Linq;
using TMPro;
using UnityEngine;

public class PetSelection : MonoBehaviour
{
    public PetType PetType;

    public void SelectPet()
    {
        var confirmationWindow = Resources.FindObjectsOfTypeAll<GameObject>()
            .FirstOrDefault(gameObject => gameObject.name == "ConfirmationWindow" && gameObject.scene.isLoaded);

        confirmationWindow.SetActive(true);

        var woodenBoard = confirmationWindow.transform.Find("WoodenBoard");

        woodenBoard
            ?.transform.Find("Title")
            ?.GetComponent<TextMeshProUGUI>()
            ?.SetText($"Choose {PetType.ToString()}?");

        var petSelectionConfirmationScript = confirmationWindow
            ?.GetComponent<PetSelectionConfirmation>();

        InitiliazePreviewTexture(woodenBoard?.transform.Find("PreviewTexture"), PetType);

        petSelectionConfirmationScript.PetType = PetType;
    }

    private void InitiliazePreviewTexture(Transform previewTexture, PetType petType)
    {
        foreach (Transform child in previewTexture)
        {
            child.gameObject.SetActive(child.name == petType.ToString());
        }
    }
}
