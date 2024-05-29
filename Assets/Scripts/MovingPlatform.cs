using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform[] wayPoints;
    [SerializeField]
    private float waitTime;
    [SerializeField]
    private float moveSpeed;
    private int wayPointCount;
    private int currentIndex = 0;

    private void Awake()
    {
        wayPointCount = wayPoints.Length;
        transform.position = wayPoints[currentIndex].position;

        currentIndex ++;

        StartCoroutine("MoveTo");
    }

    private IEnumerator MoveTo()
    {
        while (true)
        {
            yield return StartCoroutine("Movement");
            yield return new WaitForSeconds(waitTime);

            if ( currentIndex < wayPointCount-1 )
            {
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
            }
        }
    }

    private IEnumerator Movement()
    {
        while (true)
        {
            Vector3 direction = (wayPoints[currentIndex].position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;

            if (Vector3.Distance(transform.position, wayPoints[currentIndex].position) < 0.1f)
            {
                transform.position = wayPoints[currentIndex].position;
                break;
            }

            yield return null;
        }
    }
}
