#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemObjects.h")]
///<summary>Sphere scalar field that will be defined only within a sphere</summary>
public partial class URadialFalloff : UFieldNodeFloat {
// RadialFalloff
	public  URadialFalloff SetRadialFalloff(float Magnitude,float MinRange,float MaxRange,float Default,float Radius,FVector Position,EFieldFalloffType Falloff) { return default; }
	public float Magnitude;
	public float MinRange;
	public float MaxRange;
	public float Default;
	public float Radius;
	public FVector Position;
	public byte Falloff;
}
