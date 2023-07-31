#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Curve Meta Data for each name</summary>
[CppInclude("Animation/SmartName.h")]
public partial struct FCurveMetaData {
	public TArray<FBoneReference> LinkedBones;
	public byte MaxLOD;
	public FAnimCurveType Type;
}
