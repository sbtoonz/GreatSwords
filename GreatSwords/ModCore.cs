using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using BepInEx;
using BepInEx.Configuration;
using ItemManager;
using HarmonyLib;
using UnityEngine;

namespace GreatSwords
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class GreatSwordsMod : BaseUnityPlugin
    {
        private const string ModName = "GreatSwords";
        internal const string ModVersion = "0.0.1";
        private const string ModGUID = "com.littleroomdev.greatswords";
        private static Harmony harmony = null!;
        internal static Item GreatSwordSilver;
        internal static Item GreatSwordIron;
        internal static Item GreatSwordBronze;
        internal static Item GreatSwordBlackMetal;

        public void Awake()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            harmony = new(ModGUID);
            harmony.PatchAll(assembly);

            GreatSwordSilver = new Item("greatswords", "Sword_GreatSilver");
            GreatSwordIron = new Item("greatswords", "Sword_GreatIron");
            GreatSwordBronze = new Item("greatswords", "Sword_GreatBronze");
            GreatSwordBlackMetal = new Item("greatswords", "Sword_GreatBlackmetal");

           
            
            GreatSwordBronze.Name.English("Bronze 2H Sword");
            GreatSwordBronze.Description.English("It's big...");
            GreatSwordBronze.Crafting.Add(CraftingTable.Forge, 0);
            GreatSwordBronze.RequiredItems.Add("Bronze",15);
            GreatSwordBronze.RequiredItems.Add("Wood",2);
            GreatSwordBronze.RequiredItems.Add("LeatherScraps",4);

            GreatSwordBronze.Configurable = Configurability.Recipe;

            GreatSwordIron.Name.English("Iron 2H Sword");
            GreatSwordIron.Description.English("Cleave your enemies in twain.");
            GreatSwordIron.Crafting.Add(CraftingTable.Forge, 1);
            GreatSwordIron.RequiredItems.Add("Iron",30);
            GreatSwordIron.RequiredItems.Add("Wood",2);
            GreatSwordIron.RequiredItems.Add("LeatherScraps",4);

            GreatSwordIron.Configurable = Configurability.Recipe;


            GreatSwordSilver.Name.English("Silver 2H Sword");
            GreatSwordSilver.Description.English("Pure shine of silver wraps this marvellous blade.");
            GreatSwordSilver.Crafting.Add(CraftingTable.Forge, 2);
            GreatSwordSilver.RequiredItems.Add("Silver",30);
            GreatSwordSilver.RequiredItems.Add("Iron",10);
            GreatSwordSilver.RequiredItems.Add("Wood",2);
            GreatSwordSilver.RequiredItems.Add("LeatherScraps",4);

            GreatSwordSilver.Configurable = Configurability.Recipe;


            GreatSwordBlackMetal.Name.English("BlackMetal 2H Sword");
            GreatSwordBlackMetal.Description.English("They will bow to it.");
            GreatSwordBlackMetal.Crafting.Add(CraftingTable.BlackForge, 0);
            GreatSwordBlackMetal.RequiredItems.Add("BlackMetal",40);
            GreatSwordBlackMetal.RequiredItems.Add("FineWood",2);
            GreatSwordBlackMetal.RequiredItems.Add("JuteRed",4);

            GreatSwordBlackMetal.Configurable = Configurability.Recipe;

        }
    }
}
