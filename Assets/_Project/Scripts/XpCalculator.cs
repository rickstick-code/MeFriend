using UnityEngine;

public static class XpCalculator
{
    public static int GetLevelFromXp(float xp)
    {
        float level = Mathf.Log(xp / 100f, 1.15f) + 1f;
        return Mathf.Max(1, Mathf.FloorToInt(level));
    }
}
