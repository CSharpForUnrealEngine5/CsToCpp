#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InstancePackers/PCGInstancePackerBase.h")]
public partial class UPCGInstancePackerBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Defines the strategy for (H)ISM custom float data packing</summary>
	public  void PackInstances(FPCGContext Context,UPCGSpatialData InSpatialData,FPCGMeshInstanceList InstanceList,FPCGPackedCustomData OutPackedCustomData) {}
	///<summary>Interprets Metadata TypeId and increments OutPackedCustomData.NumCustomDataFloats appropriately. Returns false if the type could not be interpreted.</summary>
	public  bool AddTypeToPacking(int TypeId,FPCGPackedCustomData OutPackedCustomData) { return default; }
	///<summary>Build a PackedCustomData by processing each attribute in order for each point in the InstanceList</summary>
	public  void PackCustomDataFromAttributes(FPCGMeshInstanceList InstanceList,UPCGMetadata Metadata,TArray<string> AttributeNames,FPCGPackedCustomData OutPackedCustomData) {}
}
