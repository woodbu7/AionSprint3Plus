using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// static class to hold all objects in the game universe; locations, game objects, npc's
    /// </summary>
    public static partial class UniverseObjects
    {
        public static List<GameObject> GameObjects = new List<GameObject>()
        {
            new TravelerObject
            {
                Id = 1,
                Name = "Bag of Gold",
                SpaceTimeLocationId = 2,
                Description = "A small leather pouch filled with 9 gold coins.",
                Type = TravelerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 2,
                Name = "Ruby of Saron",
                SpaceTimeLocationId = 3,
                Description = "A bright red jewel, roughly the size of a robin's egg.",
                Type = TravelerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 3,
                Name = "Rotogenic Medicine",
                SpaceTimeLocationId = 1,
                Description = "A wooden box containing a small vial filled with a blue liquid.",
                PickUpMessage = "If you drink this blue liquid, you will feel a bit weird at first, but then your health will increase.",
                Type = TravelerObjectType.Medicine,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 4,
                Name = "Norlan Document ND-3075",
                SpaceTimeLocationId = 3,
                Description =
                    "Memo: Origin Errata" + "/n" +
                    "Universal Date: 378598" + "/n" +
                    "/n" +
                    "It appears a potential origin for the technology is based on Plenatia 5 in the Star Reach Galaxy.",
                Type = TravelerObjectType.Information,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 8,
                Name = "Aion Tracker",
                SpaceTimeLocationId = 0,
                Description =
                    "Standard issue device worn around wrist that allows for tracking and messaging.",
                Type = TravelerObjectType.Information,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 9,
                Name = "RatPak 47",
                SpaceTimeLocationId = 0,
                Description =
                    "Standard issue ration package contain nutrients for 72 hours.",
                Type = TravelerObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new SpaceTimeLocationObject
            {
                Id = 5,
                Name = "Boldendorian Chest",
                SpaceTimeLocationId = 2,
                Description = "A large wooden chest adorned with jewels.",
                IsDeadly = true
            },

            new SpaceTimeLocationObject
            {
                Id = 6,
                Name = "Silver Mirror",
                SpaceTimeLocationId = 2,
                Description = "A small silver mirror hanging on the wall next to a small window.",
                IsDeadly = true
            },

            new TravelerObject
            {
                Id = 7,
                Name = "Red Med",
                SpaceTimeLocationId = 1,
                Description = "A medicine bottle containing red pills. Looks like medicine of some sorts.",
                PickUpMessage = "The pills are indeed medicine, but you have bad side effects. You lose health.",
                Type = TravelerObjectType.BadMedicine,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 10,
                Name = "Envelope",
                SpaceTimeLocationId = 2,
                Description = "An unopened envelope with no address on it",
                PickUpMessage = "You open up the envelope and read the message within: \n" +
                "\n " +
                "\tImportant information have been discovered regarding a lethal liquid found in bottles that\n" +
                "\tlook like soda. Do NOT drink it, the liquid is lethal and will kill you.\n" +
                "\tI repeat, DO NOT drink it!",
                Type = TravelerObjectType.Information,
                Value = 10,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 11,
                Name = "Mysterious bottle",
                SpaceTimeLocationId = 1,
                Description = "Not sure what is in this bottle, but it looks refreshing.",
                PickUpMessage = "You take your chances and drink the mysterious liquid\n "+
                "you start to feel a bit weird, it turns out the liquid is lethal. You lose a life....",
                Type = TravelerObjectType.Poison,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 12,
                Name = "Super Key",
                SpaceTimeLocationId = 2,
                Description = "No location will be off limit with this key.",
                PickUpMessage = "You have the Super Key, travel anywhere you want!",
                Type = TravelerObjectType.Key,
                Value = 30,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 13,
                Name = "Band Aids",
                SpaceTimeLocationId = 3,
                Description = "A pack of unused band-aids.",
                PickUpMessage = "You apply the band-ad to your wounds. You have gained health points.",
                Type = TravelerObjectType.Medicine,
                Value = 5,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 14,
                Name = "Super Duper Medicine",
                SpaceTimeLocationId = 4,
                Description = "This stuff will cure anything.",
                PickUpMessage = "You drink the medicine and feel super duper afterwards. Must be from your increase in health.",
                Type = TravelerObjectType.Medicine,
                Value = 100,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 15,
                Name = "Blue Med",
                SpaceTimeLocationId = 2,
                Description = "A medicine bottle containing blue pills. Looks like medicine of some sorts.",
                PickUpMessage = "The pills are indeed medicine, but you have bad side effects. You lose health.",
                Type = TravelerObjectType.BadMedicine,
                Value = 65,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },
        };
    }
}
