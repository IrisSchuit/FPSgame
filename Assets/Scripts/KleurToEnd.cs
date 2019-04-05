using UnityEngine;

public class KleurToEnd : MonoBehaviour
{
    public GameObject kwast;
    private Renderer rend;
    private SoundManager soundManager;

    private bool isHit = false;

    public EndUI endUI;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        endUI = FindObjectOfType<EndUI>();
        soundManager = FindObjectOfType<SoundManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            rend.material = kwast.GetComponent<Renderer>().material;
            Destroy(other.gameObject);
            soundManager.PlayAudio(0);

            if (isHit == false)
            {
                endUI.PointsUp();
                isHit = true;
            }
        }
    }
}
