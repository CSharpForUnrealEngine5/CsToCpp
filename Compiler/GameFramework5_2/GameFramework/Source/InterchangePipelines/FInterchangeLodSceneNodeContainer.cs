#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* This container exist only because UPROPERTY cannot support nested container. See FInterchangeMeshInstance</summary>
[CppInclude("InterchangePipelineMeshesUtilities.h")]
public partial struct FInterchangeLodSceneNodeContainer {
	public TArray<UInterchangeSceneNode> SceneNodes;
}
