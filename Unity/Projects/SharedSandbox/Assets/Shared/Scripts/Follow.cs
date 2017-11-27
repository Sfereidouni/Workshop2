using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SpatialSlur.SlurUnity;

/*
 * Notes
 */ 

public class Follow : MonoBehaviour
{
    public MonoBehaviour Target;
    
    [Range(1.0f, 10.0f)]
    public float Stiffness = 5.0f;

    private IFollowable _target;


    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
        _target = Target.GetComponent<IFollowable>();
    }


    // Update is called once per frame
    void Update()
    {
        if (_target != null)
            transform.position = Vector3.Lerp(transform.position, _target.Position, Time.deltaTime * Stiffness);
    }
}
