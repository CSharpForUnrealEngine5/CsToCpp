#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Box scalar field that will be defined only within a box</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UBoxFalloff : UFieldNodeFloat {
	public static UClass StaticClass() {return default;}
	///<summary>Box scalar field that will be defined only within a box</summary>
	public  UBoxFalloff SetBoxFalloff(float Magnitude,float MinRange,float MaxRange,float Default,FTransform Transform,EFieldFalloffType Falloff) { return default; }
	///<summary>Magnitude of the box falloff field</summary>
	public float Magnitude;
	///<summary>The initial function value between 0 and 1 will be scaled between MinRange and MaxRange before being multiplied by magnitude</summary>
	public float MinRange;
	///<summary>The initial function value between 0 and 1 will be scaled between MinRange and MaxRange before being multiplied by magnitude</summary>
	public float MaxRange;
	///<summary>The field value will be set to Default if the sample distance from the box is higher than the scale of the transform</summary>
	public float Default;
	///<summary>Translation, Rotation and Scale of the unit box</summary>
	public FTransform Transform;
	///<summary>Type of falloff function used to model the evolution of the field from the box surface to the sample position</summary>
	public EFieldFalloffType Falloff;
}
