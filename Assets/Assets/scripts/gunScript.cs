using UnityEngine;
using VRTK;


public class gunScript : MonoBehaviour {

   
    public VRTK.VRTK_ControllerEvents controllerEvents;
    private GameObject bullet;
    private float bulletLife = 5f;
    private float bulletSpeed = 2000f;
    public float timeBetweenShots = 0.000005f;  // Allow 3 shots per second
    public float timeLastShot = 0f;


    // Update is called once per frame
    void Update () {
		if ( (Time.time >= (timeLastShot + timeBetweenShots) - .7) && controllerEvents.triggerPressed)
        {
            timeLastShot = Time.time;
            FireBullet();
            
        }
	}
    
    protected void Start()
    {
        bullet = transform.Find("Bullet").gameObject;
        bullet.SetActive(false);
    }

    private void FireBullet()
    {
            GameObject bulletClone = Instantiate(bullet, bullet.transform.position, bullet.transform.rotation) as GameObject;
            bulletClone.SetActive(true);
            Rigidbody rb = bulletClone.GetComponent<Rigidbody>();
            rb.AddForce(-bullet.transform.forward * bulletSpeed);
            Destroy(bulletClone, bulletLife);
          
    }
}
