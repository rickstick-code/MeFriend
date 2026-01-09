using System.IO;
using UnityEngine;

public static class SaveAndLoadHandler
{
    private static string SavePath => Path.Combine(Application.persistentDataPath, "savefile.json");

    public static GameState State { get; private set; } = new GameState();

    public static void Save()
    {
        var json = JsonUtility.ToJson(State, true);
        File.WriteAllText(SavePath, json);
    }

    public static void LoadOrCreate()
    {
        if (!File.Exists(SavePath))
        {
            State = new GameState();
            Save();
            return;
        }

        var json = File.ReadAllText(SavePath);
        var loaded = JsonUtility.FromJson<GameState>(json);

        State = loaded ?? new GameState();
        if (State.InvetorySlots == null) State.InvetorySlots = new();
        if (State.UnlockedAchievements == null) State.UnlockedAchievements = new();
        if (State.ClaimedAchievements == null) State.ClaimedAchievements = new();
    }

    public static void DeleteSave()
    {
        if (File.Exists(SavePath))
            File.Delete(SavePath);

        State = new GameState();
    }
}
