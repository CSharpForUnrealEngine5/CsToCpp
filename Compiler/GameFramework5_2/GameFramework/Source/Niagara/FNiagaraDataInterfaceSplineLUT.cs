#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceSpline.h")]
public partial struct FNiagaraDataInterfaceSplineLUT {
// NiagaraDataInterfaceSplineLUT
	public TArray<FVector> Positions;
	public TArray<FVector> Scales;
	public TArray<FQuat> Rotations;
	public float SplineLength;
	public float SplineDistanceStep;
	public float InvSplineDistanceStep;
	public int MaxIndex;
}
