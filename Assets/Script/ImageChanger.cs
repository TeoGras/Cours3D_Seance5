using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    [SerializeField] private Image _imageComponent;
    // Start is called before the first frame update
    void Start()
    {
        Sprite sprite = Resources.Load<Sprite>("Images/NGNL");
        _imageComponent.sprite = sprite;
    }

   
}
