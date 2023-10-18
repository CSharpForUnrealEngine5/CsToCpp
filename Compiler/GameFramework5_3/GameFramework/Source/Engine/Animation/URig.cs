namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>URig : that has rigging data for skeleton</summary>
[CppInclude("Animation/Rig.h")]
public partial class URig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Skeleton bone tree - each contains name and parent index*</summary>
	public TArray<FTransformBase> TransformBases;
	///<summary>Skeleton bone tree - each contains name and parent index*</summary>
	public TArray<FNode> Nodes;
}
