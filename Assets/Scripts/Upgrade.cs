using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public SwitchCharacter _switch;

    private void Start()
    {
        _switch = _switch.gameObject.GetComponent<SwitchCharacter>();
    }

    public void GetHit()
    {
        Debug.Log("got hit!");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _switch.version++;
            _switch.Switch(this.gameObject);
            gameObject.SetActive(false);
        }
    }
}
