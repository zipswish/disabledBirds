﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class Move : MonoBehaviour
    {
        public float speed;

        // Start is called before the first frame update
        void Start() { }

        // Update is called once per frame
        void Update()
        {
            transform.position += Time.deltaTime * this.speed * Vector3.left;
            if (transform.position.x <= -3f) {
                Destroy(gameObject);
            }
        }
    }
}
