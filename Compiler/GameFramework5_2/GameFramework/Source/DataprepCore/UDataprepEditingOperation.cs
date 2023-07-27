#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepOperation.h")]
///<summary>Base class for all Dataprep editing operations</summary>
public partial class UDataprepEditingOperation : UDataprepOperation {
// DataprepEditingOperation
	public  UObject AddAsset(UObject Asset,string AssetName) { return default; }
	public  UObject CreateAsset(UClass AssetClass,string AssetName) { return default; }
	public  AActor CreateActor(UClass ActorClass,string ActorName) { return default; }
	public  void RemoveObject(UObject Object,bool bLocalContext/*=false*/) {}
	public  void RemoveObjects(TArray<UObject> Objects,bool bLocalContext/*=false*/) {}
	public  void DeleteObject(UObject Objects) {}
	public  void DeleteObjects(TArray<UObject> Objects) {}
}
