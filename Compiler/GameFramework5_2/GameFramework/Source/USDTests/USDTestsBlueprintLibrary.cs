#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Library of functions that can be used via Python scripting to help testing the other USD functionality</summary>
[CppInclude("USDTestsBlueprintLibrary.h")]
public partial class USDTestsBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Helps test the effects of blueprint recompilation on the spawned actors and assets when a stage is opened.</summary>
	public static bool RecompileBlueprintStageActor(AUsdStageActor BlueprintDerivedStageActor) { return default; }
	///<summary>Intentionally dirties the UBlueprint for the given stage actor&#39;s generated class.</summary>
	public static void DirtyStageActorBlueprint(AUsdStageActor BlueprintDerivedStageActor) {}
	///<summary>Queries a subtree vertex count using the stage actor&#39;s info cache, which is not yet exposed to blueprint.</summary>
	public static long GetSubtreeVertexCount(AUsdStageActor StageActor,string PrimPath) { return default; }
	///<summary>Queries a subtree material slot count using the stage actor&#39;s info cache, which is not yet exposed to blueprint.</summary>
	public static long GetSubtreeMaterialSlotCount(AUsdStageActor StageActor,string PrimPath) { return default; }
	///<summary>Internally opens the provided stage and sets it on the stage actor via C++</summary>
	public static void SetUsdStageCpp(AUsdStageActor StageActor,string NewStageRootLayer) {}
	///<summary>Clears the editor transaction history (useful to be run before GC, to check for otherwise unreferenced assets)</summary>
	public static void ClearTransactionHistory() {}
}
