using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject[] prefabs;
    [SerializeField] GameObject cloneObject;
    [SerializeField] int createCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        while (createCount < 4)
        {
            if (cloneObject == null)
            {
                cloneObject = Instantiate(prefabs[createCount++]);
            }

            yield return new WaitForSeconds(3f);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(cloneObject);
        }
    }
}