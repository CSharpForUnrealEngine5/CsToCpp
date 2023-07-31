#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to capture a &#39;snapshot&#39; of the scene from a single plane and feed it to a render target.</summary>
[CppInclude("Components/SceneCaptureComponent2D.h")]
public partial class USceneCaptureComponent2D : USceneCaptureComponent {
	///<summary>ProjectionType</summary>
	public ECameraProjectionMode ProjectionType;
	///<summary>Camera field of view (in degrees).</summary>
	public float FOVAngle;
	///<summary>The desired width (in world units) of the orthographic view (ignored in Perspective mode)</summary>
	public float OrthoWidth;
	///<summary>Output render target of the scene capture that can be read in materials.</summary>
	public UTextureRenderTarget2D TextureTarget;
	///<summary>When enabled, the scene capture will composite into the render target instead of overwriting its contents.</summary>
	public ESceneCaptureCompositeMode CompositeMode;
	///<summary>PostProcessSettings</summary>
	public FPostProcessSettings PostProcessSettings;
	///<summary>Range (0.0, 1.0) where 0 indicates no effect, 1 indicates full effect.</summary>
	public float PostProcessBlendWeight;
	///<summary>bOverride_CustomNearClippingPlane</summary>
	public bool bOverride_CustomNearClippingPlane;
	///<summary>Set bOverride_CustomNearClippingPlane to true if you want to use a custom clipping plane instead of GNearClippingPlane.</summary>
	public float CustomNearClippingPlane;
	///<summary>Whether a custom projection matrix will be used during rendering. Use with caution. Does not currently affect culling</summary>
	public bool bUseCustomProjectionMatrix;
	///<summary>The custom projection matrix to use</summary>
	public FMatrix CustomProjectionMatrix;
	///<summary>In case of orthographic camera, generate a fake view position that has a non-zero W component. The view position will be derived based on the view matrix.</summary>
	public bool bUseFauxOrthoViewPos;
	///<summary>Render the scene in n frames (i.e TileCount) - Ignored in Perspective mode, works only in Orthographic mode when CaptureSource uses SceneColor (not FinalColor)</summary>
	public bool bEnableOrthographicTiling;
	///<summary>Number of X tiles to render. Ignored in Perspective mode, works only in Orthographic mode</summary>
	public int NumXTiles;
	///<summary>Number of Y tiles to render. Ignored in Perspective mode, works only in Orthographic mode</summary>
	public int NumYTiles;
	///<summary>Enables a clip plane while rendering the scene capture which is useful for portals.</summary>
	public bool bEnableClipPlane;
	///<summary>Base position for the clip plane, can be any position on the plane.</summary>
	public FVector ClipPlaneBase;
	///<summary>Normal for the plane.</summary>
	public FVector ClipPlaneNormal;
	///<summary>True if we did a camera cut this frame. Automatically reset to false at every capture.</summary>
	public bool bCameraCutThisFrame;
	///<summary>Treat unrendered opaque pixels as fully translucent. This is important for effects such as exponential weight fog, so it does not get applied on unrendered opaque pixels.</summary>
	public bool bConsiderUnrenderedOpaquePixelAsFullyTranslucent;
	///<summary>Adds an Blendable (implements IBlendableInterface) to the array of Blendables (if it doesn&#39;t exist) and update the weight</summary>
	public  void AddOrUpdateBlendable(object /*InBlendableObject*/ InBlendableObject,float InWeight/*=1.0f*/) {}
	///<summary>Removes a blendable.</summary>
	public  void RemoveBlendable(object /*InBlendableObject*/ InBlendableObject) {}
	///<summary>Render the scene to the texture target immediately.</summary>
	public  void CaptureScene() {}
}
