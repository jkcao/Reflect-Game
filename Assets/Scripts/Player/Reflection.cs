﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflection : Player {
	protected override void Movement(float horizontal, bool jump) {
		// Moves RL and jumps if input & able.
		if (isGrounded && jump) {
            rigidBody.velocity = new Vector2(speed * horizontal, jumpHeight);
        } else {
			rigidBody.velocity = new Vector2 (-(speed * horizontal), rigidBody.velocity.y);
			isGrounded = false;
		}
	}
}