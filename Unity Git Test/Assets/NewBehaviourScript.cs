using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Renderer renderer;

    private void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
        renderer.material.color = Color.red;
    }
}
