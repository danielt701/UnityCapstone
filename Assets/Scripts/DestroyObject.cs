using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObject : MonoBehaviour
{
    private Renderer rend;

    [SerializeField]
    private Color colorToTurnTo = Color.clear;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        StartCoroutine(ChangeColorToLight());
    }

    public IEnumerator ChangeColorToLight()
    {
        yield return new WaitForSeconds(3f);
        rend.material.color = colorToTurnTo;
       
    }
    private void Update()
    {
        Destroy(gameObject, 6f);
    }
}
