#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/VectorFieldComponent.h")]
///<summary>A Component referencing a vector field.</summary>
public partial class UVectorFieldComponent : UPrimitiveComponent {
// VectorFieldComponent
	public UVectorField VectorField;
	public float Intensity;
	public float Tightness;
	public bool bPreviewVectorField;
	public  void SetIntensity(float NewIntensity) {}
}
