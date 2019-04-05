using UnityEngine;
public class Emmer : MonoBehaviour
{
    private bool triggerEntered = false;
    //public Renderer rend;
    public Material[] mats;
    public GameObject kwast;
    public int materialNumber;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && triggerEntered)
        {
            Debug.Log("PAK DE VERF");
            kwast.GetComponent<Renderer>().material = mats[materialNumber];
        }
    }

    void OnTriggerEnter(Collider other)
    {
        triggerEntered = true;
        Debug.Log("trigger entered");
    }

    void OnTriggerExit(Collider other)
    {
        triggerEntered = false;
        Debug.Log("trigger exit");
    }
}
