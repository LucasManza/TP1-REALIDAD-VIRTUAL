using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ChangeColour : MonoBehaviour
{
    public Material Material;
    private Collider _collider;
    private bool _stateIn;

    // Use this for initialization
    void Start()
    {
        _collider = GetComponent<Collider>();
        Material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        var bounds = _collider.bounds;
        var playerCollider = bounds.Contains(VRTK_DeviceFinder.HeadsetTransform().position);
        if (playerCollider && !_stateIn)
        {
            Material.color =  Random.ColorHSV();
            _stateIn = true;

        } else if (!playerCollider && _stateIn)
        { 
            _stateIn = false;
        }
    }

//	void OnTriggerEnter(Collider other)
//	{
//		if (other.gameObject.CompareTag("Player"))
//		{
//			Material.color= Random.ColorHSV();
//		}
//        
//	}
}