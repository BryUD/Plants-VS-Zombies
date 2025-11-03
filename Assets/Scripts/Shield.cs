using UnityEngine;

public class Shield : BasePlant
{

    [SerializeField]

    private ShieldData shieldData;
    private void OnEnable()
    {
        IsActive = false;
        health.InitializeHealth(shieldData.maxHealth);
        animator.Play(shieldData.idleAnimationName, 0, 0f);
        SoundManager.instance.Play(shieldData.appearSoundName);
    }

    public void Die()
    {
        IsActive = false;
        SoundManager.instance.Play(shieldData.dieSoundName);
        StartCoroutine(DieRoutine(shieldData.dieAnimationName));
    }
}


    