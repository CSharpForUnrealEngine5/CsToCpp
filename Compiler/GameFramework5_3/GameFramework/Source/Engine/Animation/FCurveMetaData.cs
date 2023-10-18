namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Curve Meta Data for each name</summary>
[CppInclude("Animation/AnimCurveMetadata.h")]
public partial struct FCurveMetaData {
	public TArray<FBoneReference> LinkedBones;
	public byte MaxLOD;
	public FAnimCurveType Type;
}
