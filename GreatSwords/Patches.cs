using HarmonyLib;
using UnityEngine;

namespace GreatSwords
{
    public class Patches
    {
        [HarmonyPatch(typeof(ZoneSystem), nameof(ZoneSystem.Awake))]
        public static class ObjectAssignerPatch
        {
            public static void Postfix()
            {
                ItemDrop donorSword = null;
                foreach (var VARIABLE in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (VARIABLE.name == "THSwordKrom")
                    {
                        donorSword = VARIABLE.gameObject.GetComponent<ItemDrop>();
                    }
                }
                if (!donorSword)
                {
                    Debug.LogError("Donor sword cant be found for SFX");
                    return;
                }
                var hitEffects = new EffectList();
                var hitTerrainEffects = new EffectList();
                var blockEffects = new EffectList();
                var triggerEffects = new EffectList();
                var trailEffects = new EffectList();
            
                hitEffects = donorSword.m_itemData.m_shared.m_hitEffect;
                hitTerrainEffects = donorSword.m_itemData.m_shared.m_hitTerrainEffect;
                blockEffects = donorSword.m_itemData.m_shared.m_blockEffect;
                triggerEffects = donorSword.m_itemData.m_shared.m_triggerEffect;
                trailEffects = donorSword.m_itemData.m_shared.m_trailStartEffect;

                GreatSwordsMod.GreatSwordSilver.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_hitEffect = hitEffects;
                GreatSwordsMod.GreatSwordSilver.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_hitTerrainEffect = hitTerrainEffects;
                GreatSwordsMod.GreatSwordSilver.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_blockEffect = blockEffects;
                GreatSwordsMod.GreatSwordSilver.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_triggerEffect = triggerEffects;
                GreatSwordsMod.GreatSwordSilver.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_trailStartEffect = trailEffects;

                GreatSwordsMod.GreatSwordIron.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_hitEffect = hitEffects;
                GreatSwordsMod.GreatSwordIron.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_hitTerrainEffect = hitTerrainEffects;
                GreatSwordsMod.GreatSwordIron.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_blockEffect = blockEffects;
                GreatSwordsMod.GreatSwordIron.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_triggerEffect = triggerEffects;
                GreatSwordsMod.GreatSwordIron.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_trailStartEffect = trailEffects;

                GreatSwordsMod.GreatSwordBronze.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_hitEffect = hitEffects;
                GreatSwordsMod.GreatSwordBronze.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_hitTerrainEffect = hitTerrainEffects;
                GreatSwordsMod.GreatSwordBronze.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_blockEffect = blockEffects;
                GreatSwordsMod.GreatSwordBronze.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_triggerEffect = triggerEffects;
                GreatSwordsMod.GreatSwordBronze.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_trailStartEffect = trailEffects;

                GreatSwordsMod.GreatSwordBlackMetal.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_hitEffect = hitEffects;
                GreatSwordsMod.GreatSwordBlackMetal.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_hitTerrainEffect = hitTerrainEffects;
                GreatSwordsMod.GreatSwordBlackMetal.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_blockEffect = blockEffects;
                GreatSwordsMod.GreatSwordBlackMetal.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_triggerEffect = triggerEffects;
                GreatSwordsMod.GreatSwordBlackMetal.Prefab.gameObject.GetComponent<ItemDrop>().m_itemData.m_shared
                    .m_trailStartEffect = trailEffects;
            }
        }
    }
}