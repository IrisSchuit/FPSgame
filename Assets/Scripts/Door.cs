using UnityEngine;

public class Door : MonoBehaviour
{
    public int amount;
    public int totalAmount = 6;

    private void Totaal()
    {

        if (amount == totalAmount)
        {
            Destroy(this.gameObject);
        }
    }

    public void Punten()
    {
        amount++;
        Totaal();
    }
}
