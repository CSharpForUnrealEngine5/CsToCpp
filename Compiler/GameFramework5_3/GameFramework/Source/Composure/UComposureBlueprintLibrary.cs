namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposureBlueprintLibrary.h")]
public partial class UComposureBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Creates a Player Compositing Target which you can modify during gameplay.</summary>
	public static UComposurePlayerCompositingTarget CreatePlayerCompositingTarget(UObject WorldContextObject) { return default; }
	///<summary>Returns a non-centered projection matrix.</summary>
	public static void GetProjectionMatrixFromPostMoveSettings(FComposurePostMoveSettings PostMoveSettings,float HorizontalFOVAngle,float AspectRatio,FMatrix ProjectionMatrix) {}
	///<summary>Returns UV transformation matrix and its inversed to crop.</summary>
	public static void GetCroppingUVTransformationMatrixFromPostMoveSettings(FComposurePostMoveSettings PostMoveSettings,float AspectRatio,FMatrix CropingUVTransformationMatrix,FMatrix UncropingUVTransformationMatrix) {}
	///<summary>Sets parameters of a material that uses Composure&#39;s MF_UVMap_SampleLocation material function.</summary>
	public static void SetUVMapSettingsToMaterialParameters(FComposureUVMapSettings UVMapSettings,UMaterialInstanceDynamic Material) {}
	///<summary>Converts displacement encoding parameters to decoding parameters.</summary>
	public static void InvertUVDisplacementMapEncodingParameters(FVector2D In,FVector2D Out) {}
	///<summary>Returns the red and green channel factors from percentage of chromatic aberration.</summary>
	public static void GetRedGreenUVFactorsFromChromaticAberration(float ChromaticAberrationAmount,FVector2D RedGreenUVFactors) {}
	///<summary>Returns display gamma of a given player camera manager, or 0 if no scene viewport attached.</summary>
	public static void GetPlayerDisplayGamma(APlayerCameraManager PlayerCameraManager,float DisplayGamma) {}
	///<summary>CopyCameraSettingsToSceneCapture</summary>
	public static void CopyCameraSettingsToSceneCapture(UCameraComponent SrcCamera,USceneCaptureComponent2D DstCaptureComponent,float OriginalFocalLength,float OverscanFactor/*=1.0f*/) {}
	///<summary>Create a new Composure in the level without any parenting relationship.</summary>
	public static ACompositingElement CreateComposureElement(FName ElementName,UClass ClassType,AActor LevelContext/*=nullptr*/) { return default; }
	///<summary>Get a specific composure element</summary>
	public static ACompositingElement GetComposureElement(FName ElementName) { return default; }
	///<summary>Delete a specific composure element without evoking prompt window. Will delete all of its children as well.</summary>
	public static void DeleteComposureElementAndChildren(FName ElementToDelete) {}
	///<summary>Rename a specific composure element</summary>
	public static bool RenameComposureElement(FName OriginalElementName,FName NewElementName) { return default; }
	///<summary>Attach one composure element as the child to another composure element in the scene.</summary>
	public static bool AttachComposureElement(FName ParentName,FName ChildName) { return default; }
	///<summary>Determines if the specified element is being rendered by the hidden compositing viewport.</summary>
	public static bool IsComposureElementDrawing(ACompositingElement CompElement) { return default; }
	///<summary>Request redrawing the compositing editor viewport  if it is valid.</summary>
	public static void RequestRedrawComposureViewport() {}
	///<summary>Re-queries the scene for element actors and rebuilds the authoritative list used by the editor.</summary>
	public static void RefreshComposureElementList() {}
}
