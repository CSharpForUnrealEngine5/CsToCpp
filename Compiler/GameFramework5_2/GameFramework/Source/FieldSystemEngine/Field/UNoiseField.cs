#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a perlin noise scalar value if the sample is within a box</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UNoiseField : UFieldNodeFloat {
	public static UClass StaticClass() {return default;}
	///<summary>Defines a perlin noise scalar value if the sample is within a box</summary>
	public  UNoiseField SetNoiseField(float MinRange,float MaxRange,FTransform Transform) { return default; }
	///<summary>The initial function value between 0 and 1 will be scaled between MinRange and MaxRange</summary>
	public float MinRange;
	///<summary>The initial function value between 0 and 1 will be scaled between MinRange and MaxRange</summary>
	public float MaxRange;
	///<summary>Transform of the box in which the perlin noise will be defined</summary>
	public FTransform Transform;
}
