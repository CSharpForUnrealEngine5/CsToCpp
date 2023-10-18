namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A collection node specifies an interface for doing dynamic scene queries for actors in the world. Collections work in tandem with</summary>
[CppInclude("Graph/Nodes/MovieGraphCollectionNode.h")]
public partial class UMovieGraphCollectionNode : UMovieGraphSettingNode {
	public static UClass StaticClass() {return default;}
	///<summary>bOverride_CollectionName</summary>
	public bool bOverride_CollectionName;
	///<summary>bOverride_QueryClass</summary>
	public bool bOverride_QueryClass;
	///<summary>The name of this collection, which is used to reference this collection in the graph.</summary>
	public string CollectionName;
	///<summary>The type of query this node should run.</summary>
	public UMoviePipelineCollectionQuery QueryClass;
}
