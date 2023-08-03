#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set a radial vector value, the direction being the vector from the sample position to the field one. The output is equal to magnitude * direction</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class URadialVector : UFieldNodeVector {
	public static UClass StaticClass() {return default;}
	///<summary>Set a radial vector value. The direction is the normalized vector from the field position to the sample one. The output is equal to this direction * magnitude.</summary>
	public  URadialVector SetRadialVector(float Magnitude,FVector Position) { return default; }
	///<summary>Magnitude of the radial vector field</summary>
	public float Magnitude;
	///<summary>Center position of the radial vector field</summary>
	public FVector Position;
}
