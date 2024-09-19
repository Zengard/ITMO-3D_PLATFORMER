using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    private float _timeToDisable = 5;
    [SerializeField] private float speed = 4;
    [SerializeField] GameObject originPosition;

    private float direction = 1;

    private void Start()
    {
        transform.position = originPosition.transform.position;
        direction = originPosition.transform.localScale.x;
    }


    private void Update()
    {
        transform.Translate(new Vector3(direction, 0,0) * speed * Time.deltaTime);

        _timeToDisable = _timeToDisable - Time.deltaTime;

        if(_timeToDisable < 0)
        {
            _bullet.SetActive(false);
        }
    }

    private void OnEnable()
    {
        _timeToDisable = 5;
        transform.position = originPosition.transform.position;
        direction = originPosition.transform.localScale.x;
    }

    private void OnDisable()
    {
        _timeToDisable = 5;
        transform.position = originPosition.transform.position;
        direction = originPosition.transform.localScale.x;
    }
}
