using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public float duration;
    private GameObject player;
    private GameObject timeline;
    public GameObject followingObject;

    public enum FollowType:byte
    {
        followX,
        followXY,
        deactFollow
    }
    public FollowType follow=FollowType.followX;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (follow == FollowType.followX)
            {
                followingObject.transform.parent = timeline.transform;
            }
            else if (follow == FollowType.followXY)
                followingObject.transform.parent = player.transform;
            else
                followingObject.transform.parent = null;
        }   
    }
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        timeline = GameObject.FindWithTag("Timeline");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
