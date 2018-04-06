using System.Collections;
using System.Collections.Generic;
using System.Deployment.Internal;
using UnityEngine;

public class Instantion : MonoBehaviour
{
    public int CubesQuantity;
    public Material material;
    public GameObject GameObject;
    public float XMinLimit;
    public float XMaxLimit;
    public float YMinLimit;
    public float YMaxLimit;
    public float ZMinLimit;
    public float ZMaxLimit;


    void Start()
    {
        for (int limit = 1; limit <= CubesQuantity; limit++)
        {
            var instanceObject = Instantiate(GameObject);
            var instanceMaterial = Instantiate(material);
            instanceObject.GetComponent<MeshRenderer>().material = instanceMaterial;
            instanceObject.transform.position = GeneratePosition();
            instanceObject.name = "[CubeGenereted]" + "(" + limit + ")";
        }
    }

    private Vector3 GeneratePosition()
    {
        var x = Random.Range(XMinLimit, XMaxLimit);
        var y = Random.Range(YMinLimit, YMaxLimit);
        var z = Random.Range(ZMinLimit, ZMaxLimit);
        return new Vector3(x, y, z);
    }
}