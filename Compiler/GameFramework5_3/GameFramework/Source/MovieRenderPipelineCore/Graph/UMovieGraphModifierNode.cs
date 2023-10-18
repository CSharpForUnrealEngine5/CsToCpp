namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A collection node specifies an interface for doing dynamic scene queries for actors in the world. Collections work in tandem with</summary>
[CppInclude("Graph/Nodes/MovieGraphModifierNode.h")]
public partial class UMovieGraphModifierNode : UMovieGraphSettingNode {
	public static UClass StaticClass() {return default;}
	///<summary>bOverride_ModifierName</summary>
	public bool bOverride_ModifierName;
	///<summary>bOverride_ModifiedCollectionName</summary>
	public bool bOverride_ModifiedCollectionName;
	///<summary>bOverride_ModifierClass</summary>
	public bool bOverride_ModifierClass;
	///<summary>The name of this modifier.</summary>
	public string ModifierName;
	///<summary>The name of the collection being modified.</summary>
	public string ModifiedCollectionName;
	///<summary>The modifier this node should run.</summary>
	public UMoviePipelineCollectionModifier ModifierClass;
}
