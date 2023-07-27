#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposureBlueprintLibrary.h")]
public partial class UComposureBlueprintLibrary : UBlueprintFunctionLibrary {
// ComposureBlueprintLibrary
	public static UComposurePlayerCompositingTarget CreatePlayerCompositingTarget(UObject WorldContextObject) { return default; }
	public static void GetProjectionMatrixFromPostMoveSettings(FComposurePostMoveSettings PostMoveSettings,float HorizontalFOVAngle,float AspectRatio,FMatrix ProjectionMatrix) {}
	public static void GetCroppingUVTransformationMatrixFromPostMoveSettings(FComposurePostMoveSettings PostMoveSettings,float AspectRatio,FMatrix CropingUVTransformationMatrix,FMatrix UncropingUVTransformationMatrix) {}
	public static void SetUVMapSettingsToMaterialParameters(FComposureUVMapSettings UVMapSettings,UMaterialInstanceDynamic Material) {}
	public static void InvertUVDisplacementMapEncodingParameters(FVector2D In,FVector2D Out) {}
	public static void GetRedGreenUVFactorsFromChromaticAberration(float ChromaticAberrationAmount,FVector2D RedGreenUVFactors) {}
	public static void GetPlayerDisplayGamma(APlayerCameraManager PlayerCameraManager,float DisplayGamma) {}
	public static void CopyCameraSettingsToSceneCapture(UCameraComponent SrcCamera,USceneCaptureComponent2D DstCaptureComponent,float OriginalFocalLength,float OverscanFactor/*=1.0f*/) {}
	public static ACompositingElement CreateComposureElement(string ElementName,UClass ClassType,AActor LevelContext/*=nullptr*/) { return default; }
	public static ACompositingElement GetComposureElement(string ElementName) { return default; }
	public static void DeleteComposureElementAndChildren(string ElementToDelete) {}
	public static bool RenameComposureElement(string OriginalElementName,string NewElementName) { return default; }
	public static bool AttachComposureElement(string ParentName,string ChildName) { return default; }
	public static bool IsComposureElementDrawing(ACompositingElement CompElement) { return default; }
	public static void RequestRedrawComposureViewport() {}
	public static void RefreshComposureElementList() {}
}
