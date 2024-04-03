using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _WorldVisual.Scripts.Enums {
    public enum Material{
        AIR,
        ANDESITE,
        DEEPSLATE,
        STONE,
        GRANITE,
        DIRT,
        GRASS_BLOCK,
        OAK_LEAVES,
        DIORITE,
        IRON_ORE,
        COPPER_ORE,
        BIRCH_LEAVES,
        BIRCH_LOG,
        GRAVEL,
        COAL_ORE,
        OAK_LOG,
        REDSTONE_ORE,
        DEEPSLATE_REDSTONE_ORE,
        SHORT_GRASS,
        GLOW_LICHEN,
        LAPIS_ORE,
        TUFF,
        DEEPSLATE_COPPER_ORE,
        SMOOTH_BASALT,
        DEEPSLATE_IRON_ORE,
        CALCITE,
        AMETHYST_BLOCK,
        BUDDING_AMETHYST,
        MEDIUM_AMETHYST_BUD,
        SMALL_AMETHYST_BUD
    }

    public static class MatHelper {
        public static string ConvertToPath(Material material) {
            if(material == Material.ANDESITE) return "textures/block/andesite.png";
            if(material == Material.STONE) return "textures/block/stone.png";
            if(material == Material.GRANITE) return "textures/block/stone_granite.png";
            if(material == Material.DIRT) return "textures/block/dirt.png";
            if(material == Material.GRASS_BLOCK) return "textures/block/grass_side.png";
            if(material == Material.OAK_LEAVES) return "textures/block/oak_leaves.png";
            if(material == Material.DIORITE) return "textures/block/stone_diorite.png";
            if(material == Material.IRON_ORE) return "textures/block/iron_ore.png";
            if(material == Material.BIRCH_LEAVES) return "textures/block/leaves_birch_opaque.png";
            if(material == Material.BIRCH_LOG) return "textures/block/birch_log.png";
            if(material == Material.GRAVEL) return "textures/block/gravel.png";
            if(material == Material.COAL_ORE) return "textures/block/coal_ore.png";
            if(material == Material.OAK_LOG) return "textures/block/oak_log.png";
            if(material == Material.REDSTONE_ORE) return "textures/block/redstone_ore.png";
            if(material == Material.LAPIS_ORE) return "textures/block/lapis_ore.png";
            if(material == Material.SMOOTH_BASALT) return "textures/block/basalt_side.png";
            if(material == Material.SMOOTH_BASALT) return "textures/block/basalt_side.png";
            return "textures/block/stone.png";
        }
    }
}


