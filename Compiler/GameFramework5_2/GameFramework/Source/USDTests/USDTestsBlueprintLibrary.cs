#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDTestsBlueprintLibrary.h")]
///<summary>Library of functions that can be used via Python scripting to help testing the other USD functionality</summary>
public partial class USDTestsBlueprintLibrary : UBlueprintFunctionLibrary {
// SDTestsBlueprintLibrary
	public bool RecompileBlueprintStageActor(UObject BlueprintDerivedStageActor) { return default; }
	public void DirtyStageActorBlueprint(UObject BlueprintDerivedStageActor) {}
	public long GetSubtreeVertexCount(UObject StageActor,string PrimPath) { return default; }
	public long GetSubtreeMaterialSlotCount(UObject StageActor,string PrimPath) { return default; }
	public void SetUsdStageCpp(UObject StageActor,string NewStageRootLayer) {}
	public void ClearTransactionHistory() {}
}
