#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Node Mapping Container Class</summary>
[CppInclude("Animation/NodeMappingContainer.h")]
public partial class UNodeMappingContainer : UObject {
	///<summary>SourceItems</summary>
	public TMap<string,FNodeItem> SourceItems;
	///<summary>TargetItems</summary>
	public TMap<string,FNodeItem> TargetItems;
	///<summary>SourceToTarget</summary>
	public TMap<string,string> SourceToTarget;
	///<summary>source asset that is used to create source</summary>
	public TSoftObjectPtr<UObject> SourceAsset;
	///<summary>source asset that is used to create target</summary>
	public TSoftObjectPtr<UObject> TargetAsset;
}
