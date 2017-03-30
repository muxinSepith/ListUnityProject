using UnityEngine;
using System.Collections;

public class InputDetecter : MonoBehaviour
{

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomIndex = Random.Range(0, 7);
            KnapsackManager.Instance.StoreItem(randomIndex);
        }
    }

}
