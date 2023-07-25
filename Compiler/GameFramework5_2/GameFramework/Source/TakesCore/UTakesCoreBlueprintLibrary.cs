#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TakesCoreBlueprintLibrary.h")]
public partial class UTakesCoreBlueprintLibrary : UBlueprintFunctionLibrary {
// TakesCoreBlueprintLibrary
	public int ComputeNextTakeNumber(string Slate) { return default; }
	public TArray<FAssetData> FindTakes(string Slate,int TakeNumber/*=0*/) { return default; }
	public void FOnTakeRecorderSlateChanged(string Slate) {}
	public void FOnTakeRecorderTakeNumberChanged(int TakeNumber) {}
	public void SetOnTakeRecorderSlateChanged(FOnTakeRecorderSlateChanged OnTakeRecorderSlateChanged) {}
	public void SetOnTakeRecorderTakeNumberChanged(FOnTakeRecorderTakeNumberChanged OnTakeRecorderTakeNumberChanged) {}
}
