using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TextureSwitch : MonoBehaviour
{
    private Material curTexture;
    [SerializeField] private GameObject[] texturesGameObjects;
    [SerializeField] private  Texture[] texturesMaterials;
   [SerializeField] private List<float> NormalStrength = new List<float>();
    [SerializeField]Terrain terrain;
    [SerializeField]GameObject[] water;
    private float terrainNorm;
    private float WaterNorm;

    // Start is called before the first frame update
    void Start()
    {
        texturesGameObjects =  GameObject.FindGameObjectsWithTag("LightingChange");
        foreach (GameObject obj in texturesGameObjects)
        {
            if (obj.GetComponent<Renderer>().material.HasFloat("_Normal_Strength"))
            {
                NormalStrength.Add(obj.GetComponent<Renderer>().material.GetFloat("_Normal_Strength"));
            }
        }  
        terrainNorm = terrain.materialTemplate.GetFloat("_Normal_Strength");
        foreach (GameObject obj in water)
        {
            WaterNorm =  obj.GetComponent<Renderer>().material.GetFloat("_Normal_Strength");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            foreach (var obj in texturesGameObjects)
            {
                if (obj.name.Contains("Wall"))
                {
                    obj.GetComponent<Renderer>().material.mainTexture = texturesMaterials[0];
                }
                else if (obj.name.Contains("Rock"))
                {
                    obj.GetComponent<Renderer>().material.mainTexture = texturesMaterials[1];
                }
                else if (obj.name.Contains("Cube") || obj.name.Contains("Cube"))
                {
                    obj.GetComponent<Renderer>().material.mainTexture = texturesMaterials[2];
                }
                else if (obj.name.Contains("New monster"))
                {
                    obj.GetComponent<Renderer>().material.mainTexture = texturesMaterials[3];
                    var list = obj.GetComponent<Renderer>().material.GetTexture("_SecondTex");
                    list = texturesMaterials[4];
                }
                else if (obj.name.Contains("Water"))
                {
                    obj.GetComponent<Renderer>().material.mainTexture = texturesMaterials[3];

                    obj.GetComponent<Renderer>().material.mainTexture = texturesMaterials[6];
                }

                terrain.materialTemplate.mainTexture = texturesMaterials[5];
            }

            for (int i = 0; i < texturesGameObjects.Length; i++)
            {
                if (texturesGameObjects[i].GetComponent<Renderer>().material.HasFloat("NormalStrength"))
                {
                    texturesGameObjects[i].GetComponent<Renderer>().material.SetFloat("_Normal_Strength",NormalStrength[i]);
                }
            }

            foreach (GameObject obj in water)
            {
                obj.GetComponent<Renderer>().material.SetFloat("_Normal_Strength",WaterNorm);
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
            texturesGameObjects[i].GetComponent<Renderer>().material.SetFloat("_Normal_Strength", 0f);
        }

        terrain.materialTemplate.mainTexture = null;
        terrain.materialTemplate.SetFloat("_Normal_Strength",0f);
    }
}
