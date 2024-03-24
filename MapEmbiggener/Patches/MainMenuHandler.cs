using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnityEngine;

namespace MapEmbiggener.Patches
{
    [HarmonyPatch(typeof(MainMenuHandler), "Awake")]
    class Main_Menu_Handler
    {
        private static void Prefix()
        {
            MapEmbiggener.instance.ExecuteAfterSeconds(0.5f, () =>
            {
                // Create the bounds border
                OutOfBoundsUtils.CreateBorder();
            });
        }
    }
}
