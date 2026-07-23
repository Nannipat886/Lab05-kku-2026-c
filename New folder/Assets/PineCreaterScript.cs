using UnityEngine;

public class PineCreaterScript : MonoBehaviour
{
    public GameObject pinePrefab;
    public float spawnRate = 3f;
    private float timer = 3f;
    public float heightoffset = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            float lowestpoint = transform.position.y - heightoffset;
            float highestpoint = transform.position.y + heightoffset;
            float randomY = Random.Range(lowestpoint, highestpoint);
            Instantiate(pinePrefab,new Vector3(transform.position.x, randomY, transform.position.z),transform.rotation);
            timer = 0f;
        }
}}
