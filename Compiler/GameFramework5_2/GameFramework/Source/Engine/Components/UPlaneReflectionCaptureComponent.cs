#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>-&gt; will be exported to EngineDecalClasses.h</summary>
[CppInclude("Components/PlaneReflectionCaptureComponent.h")]
public partial class UPlaneReflectionCaptureComponent : UReflectionCaptureComponent {
	///<summary>Radius of the area that can receive reflections from this capture.</summary>
	public float InfluenceRadiusScale;
	///<summary>PreviewInfluenceRadius</summary>
	public UDrawSphereComponent PreviewInfluenceRadius;
	///<summary>PreviewCaptureBox</summary>
	public UBoxComponent PreviewCaptureBox;
}
