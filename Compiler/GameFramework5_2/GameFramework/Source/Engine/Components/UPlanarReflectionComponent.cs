#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PlanarReflectionComponent.h")]
///<summary>UPlanarReflectionComponent</summary>
public partial class UPlanarReflectionComponent : USceneCaptureComponent {
// PlanarReflectionComponent
	public UBoxComponent PreviewBox;
	public float NormalDistortionStrength;
	public float PrefilterRoughness;
	public float PrefilterRoughnessDistance;
	public int ScreenPercentage;
	public float ExtraFOV;
	public float DistanceFromPlaneFadeStart_DEPRECATED;
	public float DistanceFromPlaneFadeEnd_DEPRECATED;
	public float DistanceFromPlaneFadeoutStart;
	public float DistanceFromPlaneFadeoutEnd;
	public float AngleFromPlaneFadeStart;
	public float AngleFromPlaneFadeEnd;
	public bool bShowPreviewPlane;
	public bool bRenderSceneTwoSided;
	public UMaterial CaptureMaterial;
}
