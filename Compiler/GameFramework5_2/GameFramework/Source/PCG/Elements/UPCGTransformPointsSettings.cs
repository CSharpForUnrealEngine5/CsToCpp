#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGTransformPoints.h")]
public partial class UPCGTransformPointsSettings : UPCGSettings {
// PCGTransformPointsSettings
	public bool bApplyToAttribute;
	public string AttributeName;
	public FVector OffsetMin;
	public FVector OffsetMax;
	public bool bAbsoluteOffset;
	public FRotator RotationMin;
	public FRotator RotationMax;
	public bool bAbsoluteRotation;
	public FVector ScaleMin;
	public FVector ScaleMax;
	public bool bAbsoluteScale;
	public bool bUniformScale;
	public bool bRecomputeSeed;
}
