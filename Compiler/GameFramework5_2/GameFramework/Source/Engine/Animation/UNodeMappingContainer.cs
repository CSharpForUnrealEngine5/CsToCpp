#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/NodeMappingContainer.h")]
///<summary>Node Mapping Container Class</summary>
public partial class UNodeMappingContainer : UObject {
// NodeMappingContainer
	public TMap<string,FNodeItem> SourceItems;
	public TMap<string,FNodeItem> TargetItems;
	public TMap<string,string> SourceToTarget;
	public TSoftObjectPtr<UObject> SourceAsset;
	public TSoftObjectPtr<UObject> TargetAsset;
}
