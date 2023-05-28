using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public AudioSource gunShot;
    private InputAction shootAction;

    void OnEnable()
    {
        shootAction = new InputAction("Fire", InputActionType.Button, "<Mouse>/leftButton");
        shootAction.Enable();
    }

    void OnDisable()
    {
        shootAction.Disable();
    }

    void Update() {

        if (shootAction.triggered) {
            Shoot();
        }
    } 

    void Shoot() {
        muzzleFlash.Play();
        gunShot.Play();

        RaycastHit hit;
        Physics.Raycast(
            fpsCam.transform.position,
            fpsCam.transform.forward, 
            out hit,
            range
        ); {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null) {
                
            }
        }
    }
}