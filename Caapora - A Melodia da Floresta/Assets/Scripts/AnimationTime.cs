using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTime : MonoBehaviour
{
    private Animator transparencyAnimation;

    public float timeToWait;

    // Start is called before the first frame update
    void Start()
    {
        transparencyAnimation = GetComponent<Animator>();

        StartCoroutine(WaitingTime());
    }

    IEnumerator WaitingTime()
    {
        yield return new WaitForSeconds(timeToWait);
        transparencyAnimation.SetBool("isTime", true);
    }
}
