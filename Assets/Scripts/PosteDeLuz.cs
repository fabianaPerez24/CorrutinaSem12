using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosteDeLuz : MonoBehaviour
{
    private SpriteRenderer poste;

    // Start is called before the first frame update
    void Start()
    {
        poste = GetComponent<SpriteRenderer>();
        StartCoroutine(LucesParpadeo());
    }

    IEnumerator LucesParpadeo()
    {
        while(true)
        {
            poste.color = Color.grey;
           yield return new WaitForSeconds(2);
            poste.color = Color.white;
            yield return new WaitForSeconds(3);
            for(int i = 0; i < 7; i++) 
            {
                poste.color = Color.white;
                yield return new WaitForSeconds(0.1f);
                poste.color = Color.grey;
                yield return new WaitForSeconds(0.1f);
            }
        }

    }
}
