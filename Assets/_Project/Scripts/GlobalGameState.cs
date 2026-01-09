using System;
using System.Collections.Generic;

[Serializable]
public class InventorySlot
{
    public string ItemId = "";
    public int Amount = 0;
    public bool IsInUse = false;
}

[Serializable]
public class GameState
{
    public PetType SelectedPet = default;

    public float Money = 0f;
    public float Xp = 0f;

    public float MaxHealth = 100f;
    public float Health = 100f;

    public float MaxEnergy = 100f;
    public float Energy = 100f;

    public float MaxHappiness = 100f;
    public float Happiness = 100f;

    public bool IsSleeping = false;
    public long LastPettingUtcSeconds = 0;

    public bool IsWorking = false;
    public long WorkEndUtcSeconds = 0;
    public float PendingWorkMoneyReward = 0f;
    public float PendingWorkEnergyCost = 0f;

    public List<InventorySlot> InvetorySlots = new();
    public List<string> UnlockedAchievements = new();
    public List<string> ClaimedAchievements = new();
}
