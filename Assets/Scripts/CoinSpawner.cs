using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinOrange;
    public GameObject coinGreen;
    public GameObject coinBlue;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public int coinsPerBatch;

    private int coinsLeft;

    void Start()
    {
        SpawnBatch();
    }

    void SpawnBatch()
    {
        for (int i = 0; i < coinsPerBatch; i++)
        {
            int type = Random.Range(0, 3);
            GameObject prefab;

            if (type == 0)
            {
                prefab = coinOrange;
            }
            else if (type == 1)
            {
                prefab = coinGreen;
            }
            else
            {
                prefab = coinBlue;
            }

            float x = Random.Range(minX, maxX);
            float y = Random.Range(minY, maxY);

            Instantiate(prefab, new Vector3(x, y, 0), Quaternion.identity);
        }

        coinsLeft = coinsPerBatch;
    }

    public void CoinCollected()
    {
        coinsLeft--;

        if (coinsLeft <= 0)
        {
            SpawnBatch();
        }
    }
}