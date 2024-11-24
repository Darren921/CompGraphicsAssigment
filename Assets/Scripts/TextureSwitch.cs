using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TextureSwitch : MonoBehaviour
{
    private Material curTexture;
    [SerializeField] private GameObject[] texturesGameObjects;
    [SerializeField] private  Texture[] texturesMaterials;
    private List<float> NormalStrength = new List<float>();
    [SerializeField]Terrain terrain;

    private float terrainNorm;

    // Start is called before the first frame update
    void Start()
    {
        texturesGameObjects =  GameObject.FindGameObjectsWithTag("LightingChange");
        foreach (GameObject obj in texturesGameObjects)
        {
            NormalStrength.Add(obj.GetComponent<Renderer>().material.GetFloat("_Normal_Strength"));
        }  
        terrainNorm = terrain.materialTemplate.GetFloat("_Normal_Strength");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            for (int i = 0; i < texturesGameObjects.Length; i++)
            {
                if (texturesGameObjects[i].name.Contains("Wall"))
                {
                    texturesGameObjects[i].GetComponent<Renderer>().material.mainTexture = texturesMaterials[0];
                }
                else if (texturesGameObjects[i].name.Contains("Rock"))
                {
                    texturesGameObjects[i].GetComponent<Renderer>().material.mainTexture = texturesMaterials[1];
                }
                else if (texturesGameObjects[i].name.Contains("Cube"))
                {
                    texturesGameObjects[i].GetComponent<Renderer>().material.mainTexture = texturesMaterials[2];
                }
                else if (texturesGameObjects[i].name.Contains("New monster"))
                {
                    texturesGameObjects[i].GetComponent<Renderer>().material.mainTexture = texturesMaterials[3];
                    var list = texturesGameObjects[i].GetComponent<Renderer>().material.GetTexture("_SecondTex");
                    list = texturesMaterials[4];
                }
              
                terrain.materialTemplate.mainTexture = texturesMaterials[5];
            }

            for (int i = 0; i < texturesGameObjects.Length; i++)
            {
                texturesGameObjects[i].GetComponent<Renderer>().material.SetFloat("_Normal_Strength",NormalStrength[i]);
            }
            terrain.materialTemplate.SetFloat("_Normal_Strength",terrainNorm);
 
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            DisableMaterial();
        }
    }

    private void DisableMaterial()
    {
        for (int i = 0; i < texturesGameObjects.Length; i++)
        {
            texturesGameObjects[i].GetComponent<Renderer>().material.mainTexture = null;
            texturesGameObjects[i].GetComponent<Renderer>().material.SetFloat("_Normal_Strength", 0.1f);
        }

        terrain.materialTemplate.mainTexture = null;
        terrain.materialTemplate.SetFloat("_Normal_Strength",0.1f);
    }
}
