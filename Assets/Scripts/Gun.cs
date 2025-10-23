using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class Gun : MonoBehaviour
{
  [SerializeField]
    
    private Health health;
  [SerializeField]
    
    private GunData gunData;
  [SerializeField]
  private InstatiatePoolObjects bulletPool;
  [SerializeField]

  private Transform bulletPivot;
  [SerializeField]

  private LayerMask enemiesLayer;
  [SerializeField]

  private float raycastOffset = 2f;
  [SerializeField]

  private Animator animator;
  private bool isShooting = false;

  private Health enemyHealth;

  private Coroutine shootCoroutine;

  private void OnEnable()
  {
    enemyHealth = null;
    isShooting = false;
    health.InitializeHealth(gunData.maxHealth);
    animator.Play(gunData.idleAnimationName, 0, 0f);
    // SoundManager.instance.Play(gunData.appearSoundName);
  }

   private void Update()
   {
     if (!isShooting && health.CurrentHealth > 0)
     {
      Vector3 right = transform.TransformDirection(Vector3.right);
      if (Physics.Raycast(transform.position + Vector3.up * raycastOffset, right, out RaycastHit hit, gunData.range, enemiesLayer))
      {
        isShooting = true;
        enemyHealth = hit.collider.GetComponent<Health>();
        shootCoroutine = StartCoroutine(ShootRoutine());
      }
      Debug.DrawRay(transform.position, right * gunData.range, Color.blue);
     }
   }
    
   

    private IEnumerator ShootRoutine()
    {
      while (enemyHealth && enemyHealth.CurrentHealth > 0)
     {
      yield return new WaitForSeconds(gunData.fireRate);
      animator.Play(gunData.shootAnimationName, 0, 0f);
       bulletPool.InstantiateObject(bulletPivot);
       SoundManager.instance.Play(gunData.shootSoundName);

     }
     isShooting = false;
     enemyHealth = null;
    }



  public void Die()
  {
    if (shootCoroutine != null)
    {
      StopCoroutine(shootCoroutine);
    }
    animator.Play(gunData.dieAnimationName, 0, 0f);
    isShooting = false;
    enemyHealth = null;
    SoundManager.instance.Play(gunData.dieShootName);
    StartCoroutine(DieRoutine());
  }


  private IEnumerator DieRoutine()
  {
    yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
    gameObject.SetActive(false);
  }
}
