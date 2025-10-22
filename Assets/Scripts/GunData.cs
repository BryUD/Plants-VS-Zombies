using UnityEngine;

[CreateAssetMenu(fileName = "GoneData", menuName = "Scriptable Objects/GoneData")]
public class GunData : ScriptableObject
{
    public float maxHealth = 100f;

    public float fireRate = 0.5f;

    public string shootAnimationName = "ShootPlant";

    public string idleAnimationName = "Idle";

    public string dieAnimationName = "Die";

    public string shootSoundName = "gun_Shoot";

    public string dieShootName = "gun_die";

    public string appearSoundName = "Appear";

}
