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

    protected override void SpecialAbility(int condition, int dir)
    {
        if (condition == 0)
        {
            GameObject block = (GameObject)Instantiate(blockPrefab);
            block.GetComponent<Transform>().position = new Vector2(transform.position.x + (dir * -1* 1.4f), transform.position.y);
        }
    }
}
