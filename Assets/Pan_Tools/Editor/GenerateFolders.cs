/**************************************************************************

Copyright:@cartzhang

Author: cartzhang

Date:[2016/1/6]

Description:

**************************************************************************/



using UnityEngine;
using System.Collections;
using System.IO;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Pan_Tools
{
    public class GenerateFolders : MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("Tools/CreateBasicFolder #&_b")]
        private static void CreateBasicFolder()
        {
            GenerateFolder();
            Debug.Log("Folders Created");
        }

        [MenuItem("Tools/CreateALLFolder")]
        private static void CreateAllFolder()
        {
            GenerateFolder(1);
            Debug.Log("Folders Created");
        }


        private static void GenerateFolder(int flag = 0)
        {
            // 文件路径
            string prjPath = Application.dataPath + "/";
            Directory.CreateDirectory(prjPath + "_Audio");
            Directory.CreateDirectory(prjPath + "_Prefabs");
            Directory.CreateDirectory(prjPath + "_Materials");
            Directory.CreateDirectory(prjPath + "_Resources");
            Directory.CreateDirectory(prjPath + "_Scripts");
            Directory.CreateDirectory(prjPath + "_Textures");
            Directory.CreateDirectory(prjPath + "_Scenes");

            if (1 == flag)
            {
                Directory.CreateDirectory(prjPath + "_Meshes");
                Directory.CreateDirectory(prjPath + "_Shaders");
                Directory.CreateDirectory(prjPath + "_GUI");
		Directory.CreateDirectory(prjPath + "_Others");
            }

            AssetDatabase.Refresh();
        }


#endif


    }
}
