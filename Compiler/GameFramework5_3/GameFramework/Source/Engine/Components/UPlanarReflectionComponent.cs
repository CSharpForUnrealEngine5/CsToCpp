namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UPlanarReflectionComponent</summary>
[CppInclude("Components/PlanarReflectionComponent.h")]
public partial class UPlanarReflectionComponent : USceneCaptureComponent {
	public static UClass StaticClass() {return default;}
	///<summary>PreviewBox</summary>
	public UBoxComponent PreviewBox;
	///<summary>Controls the strength of normals when distorting the planar reflection.</summary>
	public float NormalDistortionStrength;
	///<summary>The roughness value to prefilter the planar reflection texture with, useful for hiding low resolution.  Larger values have larger GPU cost.</summary>
	public float PrefilterRoughness;
	///<summary>The distance at which the prefilter roughness value will be achieved.</summary>
	public float PrefilterRoughnessDistance;
	///<summary>Downsample percent, can be used to reduce GPU time rendering the planar reflection.</summary>
	public int ScreenPercentage;
	///<summary>Additional FOV used when rendering to the reflection texture.</summary>
	public float ExtraFOV;
	///<summary>DistanceFromPlaneFadeStart_DEPRECATED</summary>
	public float DistanceFromPlaneFadeStart_DEPRECATED;
	///<summary>DistanceFromPlaneFadeEnd_DEPRECATED</summary>
	public float DistanceFromPlaneFadeEnd_DEPRECATED;
	///<summary>Receiving pixels at this distance from the reflection plane will begin to fade out the planar reflection.</summary>
	public float DistanceFromPlaneFadeoutStart;
	///<summary>Receiving pixels at this distance from the reflection plane will have completely faded out the planar reflection.</summary>
	public float DistanceFromPlaneFadeoutEnd;
	///<summary>Receiving pixels whose normal is at this angle from the reflection plane will begin to fade out the planar reflection.</summary>
	public float AngleFromPlaneFadeStart;
	///<summary>Receiving pixels whose normal is at this angle from the reflection plane will have completely faded out the planar reflection.</summary>
	public float AngleFromPlaneFadeEnd;
	///<summary>bShowPreviewPlane</summary>
	public bool bShowPreviewPlane;
	///<summary>Whether to render the scene as two-sided, which can be useful to hide artifacts where normal distortion would read &#39;under&#39; an object that has been clipped by the reflection plane.</summary>
	public bool bRenderSceneTwoSided;
	///<summary>The material to use on ProxyMeshComponent</summary>
	public UMaterial CaptureMaterial;
}
