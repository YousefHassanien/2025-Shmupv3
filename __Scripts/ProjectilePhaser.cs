using UnityEngine;

public class ProjectilePhaser : MonoBehaviour
{
    [Header("Phaser Settings")]
    public float waveFrequency = 2f;
    public float waveWidth = 4f;
    public float phaseShift = 0f;
    public float speed = 40f;
    
    private float birthTime;
    private float x0; 

    void Start()
    {
        birthTime = Time.time;
        x0 = transform.position.x;
    }

    void Update()
        {
            Vector3 pos = transform.position;
            pos.y += speed * Time.deltaTime;
        
            float age = Time.time - birthTime;
            float theta = Mathf.PI * 2 * age * waveFrequency;
            pos.x = x0 + waveWidth * Mathf.Sin(theta + phaseShift);

            transform.position = pos;
        }
}