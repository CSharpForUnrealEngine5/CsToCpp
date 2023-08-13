namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/EditorAnimCurveBoneLinks.h")]
public partial class UEditorAnimCurveBoneLinks : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CurveName</summary>
	public FSmartName CurveName;
	///<summary>ConnectedBones</summary>
	public TArray<FBoneReference> ConnectedBones;
	///<summary>Max (Lowest) LOD to evaluate to curve.</summary>
	public byte MaxLOD;
}
