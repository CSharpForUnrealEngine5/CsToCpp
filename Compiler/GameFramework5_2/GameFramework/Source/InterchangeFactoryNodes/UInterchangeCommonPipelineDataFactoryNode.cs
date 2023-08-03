#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This factory node is the place where pipeline can set global data that can be use by factories.</summary>
[CppInclude("InterchangeCommonPipelineDataFactoryNode.h")]
public partial class UInterchangeCommonPipelineDataFactoryNode : UInterchangeFactoryBaseNode {
	public static UClass StaticClass() {return default;}
	///<summary>Return the global offset transform set by the pipelines.</summary>
	public  bool GetCustomGlobalOffsetTransform(FTransform AttributeValue) { return default; }
	///<summary>Pipeline can set a global transform, factories will use this global offset when importing asset.</summary>
	public  bool SetCustomGlobalOffsetTransform(UInterchangeBaseNodeContainer NodeContainer,FTransform AttributeValue) { return default; }
	///<summary>Return the Bake Meshes set by the pipelines.</summary>
	public  bool GetBakeMeshes(bool AttributeValue) { return default; }
	///<summary>Pipeline can set Bake Meshes, factories will use this to identify if Global transforms should be applied to Meshes/Skeletals.</summary>
	public  bool SetBakeMeshes(UInterchangeBaseNodeContainer NodeContainer,bool AttributeValue) { return default; }
}
