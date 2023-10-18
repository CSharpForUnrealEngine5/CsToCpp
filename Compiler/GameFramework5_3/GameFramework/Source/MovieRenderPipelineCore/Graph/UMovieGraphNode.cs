namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a base class for all nodes that can exist in the UMovieGraphConfig network.</summary>
[CppInclude("Graph/MovieGraphNode.h")]
public partial class UMovieGraphNode : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Editor Node Graph representation. Not strongly typed to avoid circular dependency between editor/runtime modules.</summary>
	public UEdGraphNode GraphNode;
	///<summary>InputPins</summary>
	public TArray<UMovieGraphPin> InputPins;
	///<summary>OutputPins</summary>
	public TArray<UMovieGraphPin> OutputPins;
	///<summary>Properties which can be dynamically declared on the node (vs. native properties which are always present).</summary>
	public FInstancedPropertyBag DynamicProperties;
	///<summary>Tracks which properties have been exposed on the node as inputs.</summary>
	public TArray<FMovieGraphPropertyInfo> ExposedPropertyInfo;
	///<summary>NodePosX</summary>
	public int NodePosX;
	///<summary>NodePosY</summary>
	public int NodePosY;
	///<summary>NodeComment</summary>
	public string NodeComment;
	///<summary>bIsCommentBubblePinned</summary>
	public bool bIsCommentBubblePinned;
	///<summary>bIsCommentBubbleVisible</summary>
	public bool bIsCommentBubbleVisible;
	///<summary>A GUID which uniquely identifies this node.</summary>
	public FGuid Guid;
}
