using HarmonyLib;
using Unbound.Core;

namespace MapEmbiggener.Patches {
    [HarmonyPatch(typeof(MainMenuHandler), "Awake")]
    class Main_Menu_Handler {
        private static void Prefix() {
            MapEmbiggener.instance.ExecuteAfterSeconds(0.5f, () => {
                // Create the bounds border
                OutOfBoundsUtils.CreateBorder();
            });
        }
    }
}
