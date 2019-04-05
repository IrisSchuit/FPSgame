using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndUI : MonoBehaviour
{
    public int amount;
    public int totalAmount = 12;

    private void Totaal()
    {
        if (amount == totalAmount)
        {
            SceneManager.LoadScene("EindScherm");
        }
    }

    public void PointsUp()
    {
        amount++;
        Totaal();
    }
}
