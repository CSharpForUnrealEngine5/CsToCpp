namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Node Mapping Container Class</summary>
[CppInclude("Animation/NodeMappingContainer.h")]
public partial class UNodeMappingContainer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SourceItems</summary>
	public TMap<FName,FNodeItem> SourceItems;
	///<summary>TargetItems</summary>
	public TMap<FName,FNodeItem> TargetItems;
	///<summary>SourceToTarget</summary>
	public TMap<FName,FName> SourceToTarget;
	///<summary>source asset that is used to create source</summary>
	public TSoftObjectPtr<UObject> SourceAsset;
	///<summary>source asset that is used to create target</summary>
	public TSoftObjectPtr<UObject> TargetAsset;
}
