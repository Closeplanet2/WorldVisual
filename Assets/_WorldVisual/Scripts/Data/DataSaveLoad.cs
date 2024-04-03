using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using _WorldVisual.Scripts.Enums;
using Newtonsoft.Json;
using UnityEngine;
using Material = _WorldVisual.Scripts.Enums.Material;

namespace _WorldVisual.Scripts.Data {
    public class DataSaveLoad {

        private static string chunkDataFolder = Application.persistentDataPath + "/ChunkData";
        private static string texturePackFolder = Application.persistentDataPath + "/TexturePack";

        public static void CreateFolders() {
            Directory.CreateDirectory(chunkDataFolder);
            Directory.CreateDirectory(texturePackFolder);
        }
    
        public static List<BlockData> LoadChunkData() {
            var fileName = chunkDataFolder + "/OfficialNDG/-1-1.json";
            using (var streamReader = new StreamReader(fileName)) {
                var json = streamReader.ReadToEnd();
                var chunkData = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, List<BlockData>>>>(json);
                foreach(var key in chunkData.Keys) {
                    return chunkData[key]["blockDataArray"];
                }
            }
            return new List<BlockData>();
        }

        public static void ApplyTexturePack(string unityShader ,string texturePackName, Material material, GameObject gameObject) {
            var imageLink = $"{texturePackFolder}/{texturePackName}/assets/minecraft/{MatHelper.ConvertToPath(material)}";
            var bytes = File.ReadAllBytes(imageLink);
            var texture = new Texture2D(128, 128);
            texture.LoadImage(bytes);

            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material = new UnityEngine.Material(Shader.Find(unityShader));
            renderer.material.mainTexture = texture;
        }
    }
}

