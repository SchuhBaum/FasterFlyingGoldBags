using BepInEx;
using UnityEngine;
using Wob_Common;

namespace FasterFlyingGoldBags;

[BepInPlugin("SchuhBaum.FasterFlyingGoldBags", "FasterFlyingGoldBags", "0.0.1")]
public class MainMod : BaseUnityPlugin {
    // meta data
    public static string mod_id = "FasterFlyingGoldBags";
    public static string author = "SchuhBaum";
    public static string version = "v0.0.1";

	// variables
    public static bool is_initialized = false;

    protected void Awake() {
        if (is_initialized) return;
        is_initialized = true;
        WobPlugin.Initialise(this, this.Logger);
        WobPlugin.Patch();

        Economy_EV.ITEM_DROP_ACCELERATION     = new Vector2(1000f, 1000f);
        Economy_EV.ITEM_DROP_MAX_MAGNET_SPEED = new Vector2(60f, 60f);

        Debug.Log(mod_id + ": author "  + author);
        Debug.Log(mod_id + ": version " + version);
    }
}
