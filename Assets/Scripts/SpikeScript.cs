using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    public SpikeGenerator spikeGenerator;  

    void Update()
    {
        if (spikeGenerator != null)
        {
            transform.Translate(Vector2.left * spikeGenerator.CurrentSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
           
            spikeGenerator.GenerateNextSpikeWithGap();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
           
            Destroy(this.gameObject);
        }
    }
}