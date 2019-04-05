using UnityEngine;

public class OnHit : MonoBehaviour
{
    public GameObject kwast;
    private Renderer rend;
    private SoundManager soundManager;

    private bool isHit = false;

    public Door door;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        door = FindObjectOfType<Door>();
        soundManager = FindObjectOfType<SoundManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Projectile")
        {
            rend.material = kwast.GetComponent<Renderer>().material;
            Destroy(other.gameObject);
            soundManager.PlayAudio(0);

            if (isHit == false)
            {
                
                door.Punten();
                isHit = true;
            }
        }
    }
}
