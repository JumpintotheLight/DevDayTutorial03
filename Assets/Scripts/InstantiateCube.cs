using System.Collections;
using UnityEngine;

public class InstantiateCube : MonoBehaviour
{
    public GameObject prefab;

    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Instantiate(prefab, new Vector3(10.0f * j, 10 * i + 10.0f, 0.0f), Quaternion.identity);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
