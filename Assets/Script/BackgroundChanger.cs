using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class BackgroundChanger : MonoBehaviour
{
    [SerializeField] private Image _imageComponent;
    
    void Start()
    {
        Sprite sprite = Resources.Load<Sprite>("Background/Scene0");
        _imageComponent.sprite = sprite;
    }

    void Scene1()
    {
        Sprite sprite = Resources.Load<Sprite>("Background/Scene1");
        _imageComponent.sprite = sprite;
    }
    
    void Scene2()
    {
        Sprite sprite = Resources.Load<Sprite>("Background/Scene2");
        _imageComponent.sprite = sprite;
    }
    
    void Scene3()
    {
        Sprite sprite = Resources.Load<Sprite>("Background/Scene3");
        _imageComponent.sprite = sprite;
    }
    
}
