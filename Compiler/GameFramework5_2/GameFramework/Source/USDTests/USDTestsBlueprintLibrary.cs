#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDTestsBlueprintLibrary.h")]
///<summary>Library of functions that can be used via Python scripting to help testing the other USD functionality</summary>
public partial class USDTestsBlueprintLibrary : UBlueprintFunctionLibrary {
// SDTestsBlueprintLibrary
	public static bool RecompileBlueprintStageActor(AUsdStageActor BlueprintDerivedStageActor) { return default; }
	public static void DirtyStageActorBlueprint(AUsdStageActor BlueprintDerivedStageActor) {}
	public static long GetSubtreeVertexCount(AUsdStageActor StageActor,string PrimPath) { return default; }
	public static long GetSubtreeMaterialSlotCount(AUsdStageActor StageActor,string PrimPath) { return default; }
	public static void SetUsdStageCpp(AUsdStageActor StageActor,string NewStageRootLayer) {}
	public static void ClearTransactionHistory() {}
}
