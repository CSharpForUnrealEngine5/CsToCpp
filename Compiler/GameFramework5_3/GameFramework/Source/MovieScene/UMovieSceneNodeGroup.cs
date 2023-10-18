namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that represents a group of nodes</summary>
[CppInclude("MovieScene.h")]
public partial class UMovieSceneNodeGroup : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Name</summary>
	public FName Name;
	///<summary>Nodes that are part of this node group, stored as node tree paths</summary>
	public TArray<string> Nodes;
}
