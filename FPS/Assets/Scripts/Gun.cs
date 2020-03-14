using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gun : MonoBehaviour
{
    [Header("Stats")]
    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 15f;
    public float impactforce = 30f;
    private float nextTimeToFire = 0f;
   
    
    public int maxAmmo = 10;
    public Text maxAmmotext;
    private int currentAmmo;
    public Text CurrentAmmotext;

    public float reloadTime = 1f;
    private bool isReloading = false;

    
    [Header("Fields")]
    public ParticleSystem muzzleflash;
    public GameObject impacteffect;
    public Camera fpsCam;
    public Animator animator;
    public GameObject ReloadingText;
    public GameObject PlayerCrosshair;
   

    void Start()
    {
        currentAmmo = maxAmmo;
        
        CurrentAmmotext.text = currentAmmo.ToString();
        maxAmmotext.text = maxAmmo.ToString();
       
    }



    void Update()
    {

        if(isReloading)
        {
            return;
        }
        if(currentAmmo <= 0f)
        {
            StartCoroutine(Reload());
            return;

        }
        if(Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            
            nextTimeToFire = Time.time + 1f / fireRate;  //setting firerate
            Shoot();

        }
    }

    void OnEnable()
    {
        isReloading = false;
        animator.SetBool("Reloading", false);
    }

    IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("reloading..");
        PlayerCrosshair.SetActive(false);
        ReloadingText.SetActive(true);
        animator.SetBool("Reloading",true);
        yield return new WaitForSeconds(reloadTime -.25f);  //time it takes to reload
        animator.SetBool("Reloading", false);
        yield return new WaitForSeconds( .25f);

        currentAmmo = maxAmmo;
        CurrentAmmotext.text = currentAmmo.ToString();
        maxAmmotext.text = maxAmmo.ToString();
        isReloading = false;
        ReloadingText.SetActive(false);
        PlayerCrosshair.SetActive(true);
    }
    void Shoot()
    {
        muzzleflash.Play();
        currentAmmo--;
        CurrentAmmotext.text = currentAmmo.ToString();
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage); //calls take damage from target

                Debug.Log(damage);

            }

            Debug.Log(damage);

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactforce);
            }
           GameObject impactGO =  Instantiate(impacteffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
        }
    }
}
