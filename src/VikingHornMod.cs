// Add distance-based volume control features

using System.Collections.Generic;
using UnityEngine;

public class VikingHornMod : MonoBehaviour
{
    private const float MAX_SOUND_DISTANCE = 100f;
    private const float MIN_SOUND_DISTANCE = 5f;
    private const float BASE_VOLUME = 1.5f;

    public void PlayHornSoundWithDistance(Vector3 hornPosition)
    {
        List<Player> players = FindAllPlayers(); // Method to retrieve all players
        foreach (Player player in players)
        {
            float distance = Vector3.Distance(hornPosition, player.transform.position);
            float volume = CalculateVolumeByDistance(distance);
            player.PlaySound(volume); // Note: Assuming Player has a method to play sound
        }
    }

    private float CalculateVolumeByDistance(float distance)
    {
        if (distance > MAX_SOUND_DISTANCE)
            return 0;
        else if (distance <= MIN_SOUND_DISTANCE)
            return BASE_VOLUME;
        else
        {
            // Linear falloff
            float volumeFalloff = BASE_VOLUME - ((BASE_VOLUME / (MAX_SOUND_DISTANCE - MIN_SOUND_DISTANCE)) * (distance - MIN_SOUND_DISTANCE));
            return Mathf.Max(0, volumeFalloff); // Ensuring volume doesn't go below 0
        }
    }

    private List<Player> FindAllPlayers()
    {
        // Implementation to find and return all player instances
        return new List<Player>(); // Placeholder
    }
}