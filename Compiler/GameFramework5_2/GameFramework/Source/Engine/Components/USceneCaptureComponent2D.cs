#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SceneCaptureComponent2D.h")]
///<summary>Used to capture a 'snapshot' of the scene from a single plane and feed it to a render target.</summary>
public partial class USceneCaptureComponent2D : USceneCaptureComponent {
// SceneCaptureComponent2D
	public byte ProjectionType;
	public float FOVAngle;
	public float OrthoWidth;
	public UTextureRenderTarget2D TextureTarget;
	public byte CompositeMode;
	public FPostProcessSettings PostProcessSettings;
	public float PostProcessBlendWeight;
	public bool bOverride_CustomNearClippingPlane;
	public float CustomNearClippingPlane;
	public bool bUseCustomProjectionMatrix;
	public FMatrix CustomProjectionMatrix;
	public bool bUseFauxOrthoViewPos;
	public bool bEnableOrthographicTiling;
	public int NumXTiles;
	public int NumYTiles;
	public bool bEnableClipPlane;
	public FVector ClipPlaneBase;
	public FVector ClipPlaneNormal;
	public bool bCameraCutThisFrame;
	public bool bConsiderUnrenderedOpaquePixelAsFullyTranslucent;
	public  void AddOrUpdateBlendable(object /*InBlendableObject*/ InBlendableObject,float InWeight/*=1.0f*/) {}
	public  void RemoveBlendable(object /*InBlendableObject*/ InBlendableObject) {}
	public  void CaptureScene() {}
}
