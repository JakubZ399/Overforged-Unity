using UnityEngine;

[CreateAssetMenu(fileName = "CurrentLevelInfo", menuName = "ScriptableObjects/CurrentLevelInfo")]
public class CurrentLevelInfo : ScriptableObject
{
    public int currentLevelScore;
    public int currentLevel;
    public int bouquetsShipped;
    public int bouquetsShippedRibbon;
    public bool levelTwoUnlocked; // Radek powiedzia�, �e do wyjebania
    public bool levelTwoFinished; // to te�

    // bazowe info o lvl
}
