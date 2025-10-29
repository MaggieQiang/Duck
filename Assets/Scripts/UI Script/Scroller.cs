using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class Scroller : MonoBehaviour
{
    public float speed;
    public Vector2 direction;

    Image img;

    private void Start()
    {
        img = GetComponent<Image>();
    }

    private void Update()
    {
        img.material.mainTextureOffset += -direction.normalized * Time.deltaTime * speed;
    }
}
