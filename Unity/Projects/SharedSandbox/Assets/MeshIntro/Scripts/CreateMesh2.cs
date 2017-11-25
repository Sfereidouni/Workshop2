using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using MyAwesomeLibrary;


/// <summary>
/// 
/// </summary>
public class CreateMesh2 : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        MeshFilter filter = GetComponent<MeshFilter>();
        filter.sharedMesh = MeshFactory.CreateTexturedQuad();
	}
}
