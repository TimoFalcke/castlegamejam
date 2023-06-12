using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureDrawer : MonoBehaviour
{
    [SerializeField] private RawImage image;
    [SerializeField] private Vector2Int textureSize;
    
    [SerializeField] 
    
    private Texture2D drawingTexture;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!drawingTexture)
        {
            drawingTexture = new Texture2D(textureSize.x, textureSize.y, TextureFormat.RGB24, false);
            image.texture = drawingTexture;
        }
    }
}
