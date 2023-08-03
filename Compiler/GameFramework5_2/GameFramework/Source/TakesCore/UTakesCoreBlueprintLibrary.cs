#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TakesCoreBlueprintLibrary.h")]
public partial class UTakesCoreBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Compute the next unused sequential take number for the specified slate</summary>
	public static int ComputeNextTakeNumber(string Slate) { return default; }
	///<summary>Find all the existing takes that were recorded with the specified slate</summary>
	public static TArray<FAssetData> FindTakes(string Slate,int TakeNumber/*=0*/) { return default; }
	///<summary>FOnTakeRecorderSlateChanged</summary>
	public  void FOnTakeRecorderSlateChanged(string Slate) {}
	///<summary>FOnTakeRecorderTakeNumberChanged</summary>
	public  void FOnTakeRecorderTakeNumberChanged(int TakeNumber) {}
	///<summary>Called when the slate is changed.</summary>
	public static void SetOnTakeRecorderSlateChanged(FOnTakeRecorderSlateChanged OnTakeRecorderSlateChanged) {}
	///<summary>Called when the take number is changed.</summary>
	public static void SetOnTakeRecorderTakeNumberChanged(FOnTakeRecorderTakeNumberChanged OnTakeRecorderTakeNumberChanged) {}
}
