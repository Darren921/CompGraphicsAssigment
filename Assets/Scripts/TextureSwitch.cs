using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureSwitch : MonoBehaviour
{
    private Material curTexture;
    [SerializeField] private GameObject[] texturesGameObjects;
    [SerializeField] private  Texture[] texturesMaterials;
    [SerializeField]Terrain terrain;
    // Start is called before the first frame update
    void Start()
    {
      
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
                    texturesGameObjects[i].GetComponentInChildren<Renderer>().material.mainTexture = texturesMaterials[0];
                }
                else if (texturesGameObjects[i].name.Contains("Rock"))
                {
                    texturesGameObjects[i].GetComponentInChildren<Renderer>().material.mainTexture = texturesMaterials[1];
                }
                else if (texturesGameObjects[i].name.Contains("tree") || texturesGameObjects[i].name.Contains("Base"))
                {
                    texturesGameObjects[i].GetComponentInChildren<Renderer>().material.mainTexture = texturesMaterials[2];
                }
                else if (texturesGameObjects[i].name.Contains("New monster"))
                {
                    texturesGameObjects[i].GetComponentInChildren<Renderer>().material.mainTexture = texturesMaterials[3];
                }
              
                terrain.materialTemplate.mainTexture = texturesMaterials[10];
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            foreach (GameObject texturesGameObject in texturesGameObjects)
            {
                texturesGameObject.GetComponent<Renderer>().material.mainTexture = null;
            }
        }
    }
}
