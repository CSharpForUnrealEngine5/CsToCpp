#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Component referencing a vector field.</summary>
[CppInclude("Components/VectorFieldComponent.h")]
public partial class UVectorFieldComponent : UPrimitiveComponent {
	///<summary>The vector field asset.</summary>
	public UVectorField VectorField;
	///<summary>The intensity at which the vector field is applied.</summary>
	public float Intensity;
	///<summary>How tightly particles follow the vector field.</summary>
	public float Tightness;
	///<summary>If true, the vector field is only used for preview visualizations.</summary>
	public bool bPreviewVectorField;
	///<summary>Set the intensity of the vector field.</summary>
	public  void SetIntensity(float NewIntensity) {}
}
