using UnityEngine;
public class Schiet : MonoBehaviour
{
   
    public GameObject kwastPunt;
    public GameObject kwastMaterial;

    private GameObject prefab;
    public float speed = 40;
    public float fireRate = 0.5f;
    private float nextFire = 0.0F;

    private Vector3 offset = new Vector3(0, 0, 0);
    private Vector3 muzzlePosition;

    private GameObject projectile;

    private void Start()
    {
        prefab = Resources.Load("Projectile") as GameObject;
    }

    private void FixedUpdate()
    {
        MaterialChange();

        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                muzzlePosition = kwastPunt.transform.position - offset;
                projectile = Instantiate(prefab, muzzlePosition, Quaternion.identity) as GameObject;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                projectile.transform.parent = null;
                rb.velocity = Camera.main.transform.forward * speed;
            }
        }
        Destroy(projectile, 5f);
    }

    private void MaterialChange()
    {
        prefab.GetComponent<Renderer>().material = kwastMaterial.GetComponent<Renderer>().material;
    }



}
