#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensFile.h")]
///<summary>A Lens file containing calibration mapping from FIZ data</summary>
public partial class ULensFile : UObject {
// LensFile
	public bool EvaluateDistortionParameters(float InFocus,float InZoom,FDistortionInfo OutEvaluatedValue) { return default; }
	public bool EvaluateFocalLength(float InFocus,float InZoom,FFocalLengthInfo OutEvaluatedValue) { return default; }
	public bool EvaluateImageCenterParameters(float InFocus,float InZoom,FImageCenterInfo OutEvaluatedValue) { return default; }
	public bool EvaluateDistortionData(float InFocus,float InZoom,FVector2D InFilmback,UObject InLensHandler) { return default; }
	public bool EvaluateNodalPointOffset(float InFocus,float InZoom,FNodalPointOffset OutEvaluatedValue) { return default; }
	public bool HasFocusEncoderMapping() { return default; }
	public float EvaluateNormalizedFocus(float InNormalizedValue) { return default; }
	public bool HasIrisEncoderMapping() { return default; }
	public float EvaluateNormalizedIris(float InNormalizedValue) { return default; }
	public TArray<FDistortionPointInfo> GetDistortionPoints() { return default; }
	public TArray<FFocalLengthPointInfo> GetFocalLengthPoints() { return default; }
	public TArray<FSTMapPointInfo> GetSTMapPoints() { return default; }
	public TArray<FImageCenterPointInfo> GetImageCenterPoints() { return default; }
	public TArray<FNodalOffsetPointInfo> GetNodalOffsetPoints() { return default; }
	public bool GetDistortionPoint(float InFocus,float InZoom,FDistortionInfo OutDistortionInfo) { return default; }
	public bool GetFocalLengthPoint(float InFocus,float InZoom,FFocalLengthInfo OutFocalLengthInfo) { return default; }
	public bool GetImageCenterPoint(float InFocus,float InZoom,FImageCenterInfo OutImageCenterInfo) { return default; }
	public bool GetNodalOffsetPoint(float InFocus,float InZoom,FNodalPointOffset OutNodalPointOffset) { return default; }
	public bool GetSTMapPoint(float InFocus,float InZoom,FSTMapInfo OutSTMapInfo) { return default; }
	public void AddDistortionPoint(float NewFocus,float NewZoom,FDistortionInfo NewPoint,FFocalLengthInfo NewFocalLength) {}
	public void AddFocalLengthPoint(float NewFocus,float NewZoom,FFocalLengthInfo NewFocalLength) {}
	public void AddImageCenterPoint(float NewFocus,float NewZoom,FImageCenterInfo NewPoint) {}
	public void AddNodalOffsetPoint(float NewFocus,float NewZoom,FNodalPointOffset NewPoint) {}
	public void AddSTMapPoint(float NewFocus,float NewZoom,FSTMapInfo NewPoint) {}
	public void RemoveFocusPoint(ELensDataCategory InDataCategory,float InFocus) {}
	public void RemoveZoomPoint(ELensDataCategory InDataCategory,float InFocus,float InZoom) {}
	public void ClearAll() {}
	public void ClearData(ELensDataCategory InDataCategory) {}
	public bool HasSamples(ELensDataCategory InDataCategory) { return default; }
	public int GetTotalPointNum(ELensDataCategory InDataCategory) { return default; }
	public FLensInfo LensInfo;
	public FCameraFeedInfo CameraFeedInfo;
	public FSimulcamInfo SimulcamInfo;
	public ELensDataMode DataMode;
	public TMap<string,string> UserMetadata;
	public FEncodersTable EncodersTable;
	public FDistortionTable DistortionTable;
	public FFocalLengthTable FocalLengthTable;
	public FImageCenterTable ImageCenterTable;
	public FNodalOffsetTable NodalOffsetTable;
	public FSTMapTable STMapTable;
	public UAssetImportData AssetImportData;
	public TArray<UTextureRenderTarget2D> UndistortionDisplacementMapHolders;
	public TArray<UTextureRenderTarget2D> DistortionDisplacementMapHolders;
}
