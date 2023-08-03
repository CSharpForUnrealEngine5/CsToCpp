#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Dummy graph to hold sub-graphs for blendspaces. Not edited directly.</summary>
[CppInclude("BlendSpaceGraph.h")]
public partial class UBlendSpaceGraph : UEdGraph {
	public static UClass StaticClass() {return default;}
	///<summary>Blendspace that we wrap</summary>
	public UBlendSpace BlendSpace;
}
