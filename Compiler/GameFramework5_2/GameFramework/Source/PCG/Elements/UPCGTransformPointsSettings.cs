#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGTransformPoints.h")]
public partial class UPCGTransformPointsSettings : UPCGSettings {
	///<summary>bApplyToAttribute</summary>
	public bool bApplyToAttribute;
	///<summary>AttributeName</summary>
	public string AttributeName;
	///<summary>OffsetMin</summary>
	public FVector OffsetMin;
	///<summary>OffsetMax</summary>
	public FVector OffsetMax;
	///<summary>Set offset in world space</summary>
	public bool bAbsoluteOffset;
	///<summary>RotationMin</summary>
	public FRotator RotationMin;
	///<summary>RotationMax</summary>
	public FRotator RotationMax;
	///<summary>Set rotation directly instead of additively</summary>
	public bool bAbsoluteRotation;
	///<summary>ScaleMin</summary>
	public FVector ScaleMin;
	///<summary>ScaleMax</summary>
	public FVector ScaleMax;
	///<summary>Set scale directly instead of multiplicatively</summary>
	public bool bAbsoluteScale;
	///<summary>Scale uniformly on each axis. Uses the X component of ScaleMin and ScaleMax.</summary>
	public bool bUniformScale;
	///<summary>Recompute the seed for each new point using its new location</summary>
	public bool bRecomputeSeed;
}
