#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sphere scalar field that will be defined only within a sphere</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class URadialFalloff : UFieldNodeFloat {
	public static UClass StaticClass() {return default;}
	///<summary>Sphere scalar field that will be defined only within a sphere</summary>
	public  URadialFalloff SetRadialFalloff(float Magnitude,float MinRange,float MaxRange,float Default,float Radius,FVector Position,EFieldFalloffType Falloff) { return default; }
	///<summary>Magnitude of the sphere falloff field</summary>
	public float Magnitude;
	///<summary>The initial function value between 0 and 1 will be scaled between MinRange and MaxRange before being multiplied by magnitude</summary>
	public float MinRange;
	///<summary>The initial function value between 0 and 1 will be scaled between MinRange and MaxRange before being multiplied by magnitude</summary>
	public float MaxRange;
	///<summary>The field value will be set to Default if the sample distance from the center is higher than the radius</summary>
	public float Default;
	///<summary>Radius of the sphere falloff field</summary>
	public float Radius;
	///<summary>Center position of the sphere falloff field</summary>
	public FVector Position;
	///<summary>Type of falloff function used to model the evolution of the field from the sphere center to the sample position</summary>
	public EFieldFalloffType Falloff;
}
