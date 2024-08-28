using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        prefab = Instantiate(Resources.Load<GameObject>("Pier"));
    }
}
