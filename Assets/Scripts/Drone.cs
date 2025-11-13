using UnityEngine;

[CreateAssetMenu(fileName = "Drone", menuName = "Scriptable Objects/Drone")]
public class Drone : ScriptableObject
{
    [Header ("Gun Settings")]

    public float fireRate = 0.5f;

    public float range = 12f;
}
