using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using _WorldVisual.Scripts.Data;
using UnityEngine;

namespace _WorldVisual.Scripts.ChunkData {
    public class ChunkDataLoader : MonoBehaviour {

        public GameObject prefab;
        public Transform parent;
    
        private void Start() {
            DataSaveLoad.CreateFolders();
            foreach (var blockData in DataSaveLoad.LoadChunkData()) {
                if(blockData.GetType() == Enums.Material.AIR) continue;
                var blockObject = Instantiate(prefab, blockData.WorldLocation(), Quaternion.identity, parent);
                DataSaveLoad.ApplyTexturePack("Universal Render Pipeline/Lit", "Default HD Alpha 1.4", blockData.GetType(), blockObject);
            }
        }
    }
}


