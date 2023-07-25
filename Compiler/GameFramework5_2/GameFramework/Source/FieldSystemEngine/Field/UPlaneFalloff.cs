#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemObjects.h")]
///<summary>Plane scalar field that will be defined only within a distance from a plane</summary>
public partial class UPlaneFalloff : UFieldNodeFloat {
// PlaneFalloff
	public UObject SetPlaneFalloff(float Magnitude,float MinRange,float MaxRange,float Default,float Distance,FVector Position,FVector Normal,EFieldFalloffType Falloff) { return default; }
	public float Magnitude;
	public float MinRange;
	public float MaxRange;
	public float Default;
	public float Distance;
	public FVector Position;
	public FVector Normal;
	public byte Falloff;
}
