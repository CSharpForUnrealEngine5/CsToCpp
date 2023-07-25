#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemObjects.h")]
///<summary>Defines a perlin noise scalar value if the sample is within a box</summary>
public partial class UNoiseField : UFieldNodeFloat {
// NoiseField
	public UObject SetNoiseField(float MinRange,float MaxRange,FTransform Transform) { return default; }
	public float MinRange;
	public float MaxRange;
	public FTransform Transform;
}
