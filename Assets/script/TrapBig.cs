using UnityEngine;

public class TrapBig : MonoBehaviour
{
    public GameObject thingToShow;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().health -= 30;
            thingToShow.SetActive(true);
        }
    }
}