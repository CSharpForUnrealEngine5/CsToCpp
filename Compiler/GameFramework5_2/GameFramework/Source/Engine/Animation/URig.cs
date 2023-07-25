#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/Rig.h")]
///<summary>URig : that has rigging data for skeleton</summary>
public partial class URig : UObject {
// Rig
	public TArray<FTransformBase> TransformBases;
	public TArray<FNode> Nodes;
}
