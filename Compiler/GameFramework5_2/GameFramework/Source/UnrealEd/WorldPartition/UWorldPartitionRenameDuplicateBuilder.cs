#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRenameDuplicateBuilder.h")]
///<summary>Example Command Line: ProjectName MapName -run=WorldPartitionBuilderCommandlet -SCCProvider=Perforce -Builder=WorldPartitionRenameDuplicateBuilder -NewPackage=NewPackage [Optional: -Rename]</summary>
public partial class UWorldPartitionRenameDuplicateBuilder : UWorldPartitionBuilder {
// WorldPartitionRenameDuplicateBuilder
	public TMap<UObject,UObject> DuplicatedObjects;
}
