#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/EditorAnimCurveBoneLinks.h")]
public partial class UEditorAnimCurveBoneLinks : UObject {
	///<summary>CurveName</summary>
	public FSmartName CurveName;
	///<summary>ConnectedBones</summary>
	public TArray<FBoneReference> ConnectedBones;
	///<summary>Max (Lowest) LOD to evaluate to curve.</summary>
	public byte MaxLOD;
}
