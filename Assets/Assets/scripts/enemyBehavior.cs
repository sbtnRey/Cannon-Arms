// Modified code from https://forum.unity.com/threads/getting-an-enemy-to-move-towards-you.34295/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehavior : MonoBehaviour {

    private GameObject player;
    public float speed = 1;

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {
        if (!player)
            return;

        var distance = Vector3.Distance(player.transform.position, transform.position);

        var delta = player.transform.position - transform.position;
        delta.Normalize();

        var moveSpeed = speed * Time.deltaTime;

        transform.position = transform.position + (delta * moveSpeed);
	}
}
