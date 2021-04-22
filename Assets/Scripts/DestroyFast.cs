using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyFast : MonoBehaviour
{
    private Renderer rend;

    [SerializeField]
    private Color colorTochangeto = Color.clear;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        StartCoroutine(ChangeColorToClear());
    }

    public IEnumerator ChangeColorToClear()
    {
        yield return new WaitForSeconds(1.5f);
        rend.material.color = colorTochangeto;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 3f); 
    }
}
