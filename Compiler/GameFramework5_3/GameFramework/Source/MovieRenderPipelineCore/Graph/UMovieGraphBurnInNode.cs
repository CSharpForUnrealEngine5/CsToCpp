namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A node which generates a widget burn-in, rendered to a standalone image or composited on top of a render layer.</summary>
[CppInclude("Graph/Nodes/MovieGraphBurnInNode.h")]
public partial class UMovieGraphBurnInNode : UMovieGraphRenderPassNode {
	public static UClass StaticClass() {return default;}
	///<summary>bOverride_BurnInClass</summary>
	public bool bOverride_BurnInClass;
	///<summary>bOverride_bCompositeOntoFinalImage</summary>
	public bool bOverride_bCompositeOntoFinalImage;
	///<summary>The widget that the burn-in should use.</summary>
	public FSoftClassPath BurnInClass;
	///<summary>If true, the burn-in image will be composited into the final image pass. Does not apply to multi-layer EXR files.</summary>
	public bool bCompositeOntoFinalImage;
	///<summary>Burn-in widget instances shared with all FMovieGraphBurnInPass instances, keyed by burn-in class.</summary>
	public TMap<UClass,UMovieGraphBurnInWidget> BurnInWidgetInstances;
}
