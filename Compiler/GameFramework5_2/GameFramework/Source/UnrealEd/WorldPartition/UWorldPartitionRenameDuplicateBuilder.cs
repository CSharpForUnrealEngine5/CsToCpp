namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Example Command Line: ProjectName MapName -run=WorldPartitionBuilderCommandlet -SCCProvider=Perforce -Builder=WorldPartitionRenameDuplicateBuilder -NewPackage=NewPackage [Optional: -Rename]</summary>
[CppInclude("WorldPartition/WorldPartitionRenameDuplicateBuilder.h")]
public partial class UWorldPartitionRenameDuplicateBuilder : UWorldPartitionBuilder {
	public static UClass StaticClass() {return default;}
	///<summary>Keep duplicated objects around through GC calls.</summary>
	public TMap<UObject,UObject> DuplicatedObjects;
}
