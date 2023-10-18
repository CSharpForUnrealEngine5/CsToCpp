namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all Dataprep editing operations</summary>
[CppInclude("DataprepOperation.h")]
public partial class UDataprepEditingOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>DUplicate and add an asset to the Dataprep&#39;s and action&#39;s working set</summary>
	public UObject AddAsset(UObject Asset,string AssetName) { return default; }
	///<summary>Create and add an asset to the Dataprep&#39;s and action&#39;s working set</summary>
	public UObject CreateAsset(UClass AssetClass,string AssetName) { return default; }
	///<summary>Add an actor to the Dataprep&#39;s transient world and action&#39;s working set</summary>
	public AActor CreateActor(UClass ActorClass,string ActorName) { return default; }
	///<summary>Remove an object from the Dataprep&#39;s and/or action&#39;s working set</summary>
	public void RemoveObject(UObject Object,bool bLocalContext/*=false*/) {}
	///<summary>Remove an array of objects from the Dataprep&#39;s and/or action&#39;s working set</summary>
	public void RemoveObjects(TArray<UObject> Objects,bool bLocalContext/*=false*/) {}
	///<summary>Delete an object from the Dataprep&#39;s working set</summary>
	public void DeleteObject(UObject Objects) {}
	///<summary>Delete an array of objects from the Dataprep&#39;s and action&#39;s working set</summary>
	public void DeleteObjects(TArray<UObject> Objects) {}
}
