using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x + 1, gameObject.transform.position.y + 1);
        StartCoroutine(MovementInterval());
    }

    IEnumerator MovementInterval()
    {
        yield return new WaitForSeconds(1);

        gameObject.transform.position = new Vector2(gameObject.transform.position.x - 1, gameObject.transform.position.y - 1);
    }
}
