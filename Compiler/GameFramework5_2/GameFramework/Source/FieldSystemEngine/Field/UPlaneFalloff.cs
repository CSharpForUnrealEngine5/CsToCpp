#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Plane scalar field that will be defined only within a distance from a plane</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UPlaneFalloff : UFieldNodeFloat {
	///<summary>Plane scalar field that will be defined only within a distance from a plane</summary>
	public  UPlaneFalloff SetPlaneFalloff(float Magnitude,float MinRange,float MaxRange,float Default,float Distance,FVector Position,FVector Normal,EFieldFalloffType Falloff) { return default; }
	///<summary>Magnitude of the plane falloff field</summary>
	public float Magnitude;
	///<summary>The initial function value between 0 and 1 will be scaled between MinRange and MaxRange before being multiplied by magnitude</summary>
	public float MinRange;
	///<summary>The initial function value between 0 and 1 will be scaled between MinRange and MaxRange before being multiplied by magnitude</summary>
	public float MaxRange;
	///<summary>The field value will be set to Default if the sample distance from the plane is higher than the distance</summary>
	public float Default;
	///<summary>Distance limit for the plane falloff field</summary>
	public float Distance;
	///<summary>Plane position of the plane falloff field</summary>
	public FVector Position;
	///<summary>Plane normal of the plane falloff field</summary>
	public FVector Normal;
	///<summary>Type of falloff function used to model the evolution of the field from the plane surface to the distance isosurface</summary>
	public EFieldFalloffType Falloff;
}
