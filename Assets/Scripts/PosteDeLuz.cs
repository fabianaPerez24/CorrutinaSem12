using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosteDeLuz : MonoBehaviour
{
    public bool luces = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LucesParpadeo());
    }

    IEnumerator LucesParpadeo ()
    {
        while(true)
        { 
            luces=false;
           yield return new WaitForSeconds(2);
            luces =true;
            yield return new WaitForSeconds(3);
        }

    }
}
