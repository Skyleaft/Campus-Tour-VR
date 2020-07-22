using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController : MonoBehaviour
{
    public GameObject lift;

    [SerializeField][Range(40f, 50f)]  float lerpTime;

    float currentLerpTime;

    public float on = 0f;

    private float distance = 3.3f;

    public bool _isLearp;

    public float perc;

    public GameObject player;

    private Vector3 startPosition;
    private Vector3 endPosition;
    private Vector3 endposPlayer;
    private Vector3 endposPlayer2;




    void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition + Vector3.up * distance;
        
    }

    void Update()
    {
        if (on==1f)
        {
            _isLearp = true;
            currentLerpTime += Time.deltaTime;
            if (currentLerpTime > lerpTime)
            {
                currentLerpTime = lerpTime;
            }
            perc = currentLerpTime / lerpTime;
            transform.position = Vector3.Lerp(transform.position, endPosition, perc);

            

            if (perc > 0.06)
            {
                
            }
            else
            {
                player.transform.position = new Vector3(player.transform.position.x,Mathf.Lerp(player.transform.position.y, endposPlayer.y, perc), player.transform.position.z);
                
            }
            if (transform.position== endPosition)
            {
                on = 0f;
                _isLearp = false;
            }
        }
    }

    public void elevate()
    {
        on = 1f;
        currentLerpTime = 0f;
        if (!_isLearp)
        {
            if (transform.position == startPosition)
            {
                endPosition = transform.position + Vector3.up * distance;
                //player.transform.position = player.transform.position + Vector3.up*-0.5f;
                endposPlayer = player.transform.position + Vector3.up * distance;
            }
            else
            {
                endPosition = transform.position + Vector3.down * distance;
                endposPlayer = player.transform.position + Vector3.down * distance;
            }
        }
        
    }
    

}
