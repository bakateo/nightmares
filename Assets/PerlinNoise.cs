using UnityEngine;

public class PerlinNoise : MonoBehaviour
{
    public int width = 256;
    public int heigth = 256;

    public float scale = 200f;

    public float offsetx = 100f;
    public float offsety = 100f;

    private void Start()
    {
        while (true)
        {
            offsetx += 1;
            offsety += 1;
        }
    }

    private void Update()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = GenerateTexture();
    }

    Texture2D GenerateTexture()
    {
        Texture2D texture = new Texture2D(width, heigth);

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < heigth; y++)
            {
                Color color = CalcColor(x, y);
                texture.SetPixel(x, y, color);
            }
        }
        texture.Apply();
        return texture;
    }

    Color CalcColor(int x, int y)
    {
        float coordX = (float) x / width * scale + offsetx;
        float coordY = (float) y / heigth * scale + offsety;

        float sample = Mathf.PerlinNoise(coordX, coordY);
        return new Color(sample, sample, sample);
    }
}
