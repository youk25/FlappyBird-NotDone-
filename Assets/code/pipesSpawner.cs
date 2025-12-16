using UnityEngine;

public class pipesSpawner : MonoBehaviour
{
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;
    public GameObject pipePrefab;

    
    private void OnEnable()
    {
        InvokeRepeating(nameof(pipeSpawner), spawnRate, spawnRate);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(pipeSpawner));
    }

    private void pipeSpawner()
    {
        GameObject pipes = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);

        Destroy(pipes, 9f);
    }
};
