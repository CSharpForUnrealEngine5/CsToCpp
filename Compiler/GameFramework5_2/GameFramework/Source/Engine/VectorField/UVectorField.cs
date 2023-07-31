#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VectorField/VectorField.h")]
public partial class UVectorField : UObject {
	///<summary>Bounds of the volume in local space.</summary>
	public FBox Bounds;
	///<summary>The intensity with which to multiplie vectors in this field.</summary>
	public float Intensity;
}
