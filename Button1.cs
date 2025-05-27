
using UnityEngine;
using System.Collections;

public class Button1 : MonoBehaviour
{
    public static bool FButton;
    public GameObject Prefab;
    private int SpawnTime = 0;
    private bool Go;

    void Update()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        if (Go)
        {
            var spawnPos = transform.position;
            Instantiate(Prefab, spawnPos, Quaternion.identity);
            Go = false;
            yield return new WaitForSeconds(SpawnTime);  
        }
    }
    void OnMouseDown()
    {
        Tower1.Archor = true;
        FButton = true;
        Go = true;
    }
    
}
