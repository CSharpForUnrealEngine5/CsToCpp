namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeHash.h")]
public partial class URuntimeHashExternalStreamingObjectBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>OwningWorld</summary>
	public TSoftObjectPtr<UWorld> OwningWorld;
	///<summary>OuterWorld</summary>
	public TSoftObjectPtr<UWorld> OuterWorld;
}
