using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject spike;
    public float MinSpeed;
    public float MaxSpeed;
    public float CurrentSpeed;

    public float SpeedMultiplier;

    void Awake()
    {
        CurrentSpeed = MinSpeed;
        GenerateSpike();
    }

    public void GenerateNextSpikeWithGap()
    {
        float randomwait = Random.Range(0.1f, 5f);
        Invoke("GenerateSpike", randomwait);
    }

    public void GenerateSpike()
    {
        GameObject spikeIns = Instantiate(spike, transform.position, transform.rotation);
        
        spikeIns.GetComponent<SpikeScript>().spikeGenerator = this;
    }

    void Update()
    {
        if(CurrentSpeed < MaxSpeed)
        {
        CurrentSpeed += SpeedMultiplier;
        }
    }
}