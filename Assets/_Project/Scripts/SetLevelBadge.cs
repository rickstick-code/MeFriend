using TMPro;
using UnityEngine;

public class SetLevelBadge : MonoBehaviour
{
    TextMeshProUGUI levelBadgeText;

    void Start()
    {
        levelBadgeText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        levelBadgeText.text =XpCalculator.GetLevelFromXp(SaveAndLoadHandler.State.Xp).ToString();
    }
}
