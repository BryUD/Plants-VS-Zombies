using UnityEngine;

[CreateAssetMenu(fileName = "GunData", menuName = "Scriptable Objects/GoneData")]
public class GunData : BaseCharacterData
{
    [Header ("Gun Settings")]

    public float fireRate = 0.5f;

    public float range = 12f;

}
