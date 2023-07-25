#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemObjects.h")]
///<summary>Set a radial vector value, the direction being the vector from the sample position to the field one. The output is equal to magnitude * direction</summary>
public partial class URadialVector : UFieldNodeVector {
// RadialVector
	public UObject SetRadialVector(float Magnitude,FVector Position) { return default; }
	public float Magnitude;
	public FVector Position;
}
