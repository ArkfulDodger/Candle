using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToonLight : MonoBehaviour
{
    private Light _light;
    public Vector4 Vector = new Vector4(1,1,1,1);

    private void Awake()
    {
        _light = GetComponent<Light>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //_light.useBoundingSphereOverride = true;
        _light.boundingSphereOverride = Vector;
    }

    // Update is called once per frame
    void Update()
    {
        _light.boundingSphereOverride = Vector;
    }
}
