#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PBIK_Shared.h")]
public partial struct FPBIKBoneSetting {
	public string Bone;
	public float RotationStiffness;
	public float PositionStiffness;
	public EPBIKLimitType X;
	public float MinX;
	public float MaxX;
	public EPBIKLimitType Y;
	public float MinY;
	public float MaxY;
	public EPBIKLimitType Z;
	public float MinZ;
	public float MaxZ;
	public bool bUsePreferredAngles;
	public FVector PreferredAngles;
}
