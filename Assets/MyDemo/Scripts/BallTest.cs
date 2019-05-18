using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class BallTest : MonoBehaviour {

    private Rigidbody rigidbodyCom;
    public string eventID;      // 响应事件ID
    public float jumpSpeed;     // 速度

	// Use this for initialization
	void Start () {
        rigidbodyCom = GetComponent<Rigidbody>();
        Koreographer.Instance.RegisterForEvents(eventID, BallJump);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void BallJump(KoreographyEvent koreographyEvent) {
        Vector3 vel = rigidbodyCom.velocity;
        vel.y = jumpSpeed;
        rigidbodyCom.velocity = vel;
    }
}
