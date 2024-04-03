

using System;
using Newtonsoft.Json;
using UnityEngine;

namespace _WorldVisual.Scripts.Data {
    public class BlockData {
        [JsonProperty("CLASS_TYPE")]
        public string ClassType { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("z")]
        public int Z { get; set; }
        
        [JsonProperty("blockType")]
        public string BlockType { get; set; }

        public Vector3 WorldLocation() {
            return new Vector3(X, Y, Z);
        }

        public Enums.Material GetType() {
            return (Enums.Material) Enum.Parse(typeof(Enums.Material), BlockType);
        }
    }
}


