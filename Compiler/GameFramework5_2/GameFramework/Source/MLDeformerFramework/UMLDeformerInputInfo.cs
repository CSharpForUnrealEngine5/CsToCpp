#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MLDeformerInputInfo.h")]
///<summary>The neural network input information.</summary>
public partial class UMLDeformerInputInfo : UObject {
// MLDeformerInputInfo
	public FSoftObjectPath SkeletalMesh;
	public TArray<string> BoneNameStrings_DEPRECATED;
	public TArray<string> CurveNameStrings_DEPRECATED;
	public TArray<string> BoneNames;
	public TArray<string> CurveNames;
	public int NumBaseMeshVertices;
	public int NumTargetMeshVertices;
}
