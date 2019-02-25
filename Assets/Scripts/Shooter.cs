﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject candyPrefab;
    public float shootSpeed;
    public float shotTorque;

	
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) Shot();
	}

    public void Shot()
    {
        //プレファブからCandオブジェクトを生成
        GameObject candy = (GameObject)Instantiate(candyPrefab, transform.position, Quaternion.identity);

        //CandyオブジェクトのRigidbodyを取得し力と回転を加える 力とトルクの加算
        Rigidbody candyRigidBody = candy.GetComponent<Rigidbody>();
        candyRigidBody.AddForce(transform.forward * shootSpeed);
        candyRigidBody.AddTorque(new Vector3(0, shotTorque, 0));
    }
}