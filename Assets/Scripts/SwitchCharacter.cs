using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacter : MonoBehaviour
{
    public int version = 1;

    public GameObject ver1, ver2, ver3;
    public MoveCamera _camera;

    private void Start()
    {
        version = 1;
        _camera = _camera.GetComponent<MoveCamera>();
    }

    private void Update()
    {
   
    }
    public void Switch(GameObject gear)
    {
        Debug.Log("test switch");

        if (version > 3)
        {
            version = 3;
        }
        else if(version <1)
        {
            version = 1;
        }

        if(version == 1)
        {
            ver1.gameObject.transform.position = gear.transform.position;

            ver1.SetActive(true);
            ver2.SetActive(false);
            ver3.SetActive(false);

            _camera.target = ver1.transform;
        }
        if(version == 2)
        {
            ver2.gameObject.transform.position = gear.transform.position;

            ver1.SetActive(false);
            ver2.SetActive(true);
            ver3.SetActive(false);

            ver2.gameObject.transform.position = gear.transform.position;

            _camera.target = ver2.transform;
        }
        else if(version == 3)
        {

            ver1.SetActive(false);
            ver2.SetActive(false);
            ver3.SetActive(true);

            ver3.gameObject.transform.position = gear.transform.position;

            _camera.target = ver3.transform;
        }

    }  
}
