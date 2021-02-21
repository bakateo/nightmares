using UnityEngine;

public class PerlinNoise : MonoBehaviour
{
    public int width = 128;
    public int heigth = 128;

    public float scale = 200f;

    public float offsetx = 100f;
    public float offsety = 100f;

    private void Update()
    {
        //to simulate the static noise
        offsetx = Random.Range(0f, 99999f);
        offsety = Random.Range(0f, 99999f);

        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = GenerateTexture();
    }

    //generates the the color for every pixel on the texture and applies it
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

    //calculates position and color of pixel 
    Color CalcColor(int x, int y)
    {
        float coordX = (float) x / width * scale + offsetx;
        float coordY = (float) y / heigth * scale + offsety;

        float sample = Mathf.PerlinNoise(coordX, coordY);
        return new Color(sample, sample, sample);
    }
}
