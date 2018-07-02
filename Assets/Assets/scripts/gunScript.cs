using UnityEngine;
using VRTK;


public class gunScript : MonoBehaviour {

   
    public VRTK.VRTK_ControllerEvents controllerEvents;
    private GameObject bullet;
    private float bulletLife = 5f;
    private float bulletSpeed = 100f;
    

    // Update is called once per frame
    void Update () {
		if ( controllerEvents.triggerClicked)
        {
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
