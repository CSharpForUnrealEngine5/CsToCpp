#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposureBlueprintLibrary.h")]
public partial class UComposureBlueprintLibrary : UBlueprintFunctionLibrary {
// ComposureBlueprintLibrary
	public UObject CreatePlayerCompositingTarget(UObject WorldContextObject) { return default; }
	public void GetProjectionMatrixFromPostMoveSettings(FComposurePostMoveSettings PostMoveSettings,float HorizontalFOVAngle,float AspectRatio,FMatrix ProjectionMatrix) {}
	public void GetCroppingUVTransformationMatrixFromPostMoveSettings(FComposurePostMoveSettings PostMoveSettings,float AspectRatio,FMatrix CropingUVTransformationMatrix,FMatrix UncropingUVTransformationMatrix) {}
	public void SetUVMapSettingsToMaterialParameters(FComposureUVMapSettings UVMapSettings,UObject Material) {}
	public void InvertUVDisplacementMapEncodingParameters(FVector2D In,FVector2D Out) {}
	public void GetRedGreenUVFactorsFromChromaticAberration(float ChromaticAberrationAmount,FVector2D RedGreenUVFactors) {}
	public void GetPlayerDisplayGamma(UObject PlayerCameraManager,float DisplayGamma) {}
	public void CopyCameraSettingsToSceneCapture(UObject SrcCamera,UObject DstCaptureComponent,float OriginalFocalLength,float OverscanFactor/*=1.0f*/) {}
	public UObject CreateComposureElement(string ElementName,UClass ClassType,UObject LevelContext/*=nullptr*/) { return default; }
	public UObject GetComposureElement(string ElementName) { return default; }
	public void DeleteComposureElementAndChildren(string ElementToDelete) {}
	public bool RenameComposureElement(string OriginalElementName,string NewElementName) { return default; }
	public bool AttachComposureElement(string ParentName,string ChildName) { return default; }
	public bool IsComposureElementDrawing(UObject CompElement) { return default; }
	public void RequestRedrawComposureViewport() {}
	public void RefreshComposureElementList() {}
}
