namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Lens file containing calibration mapping from FIZ data</summary>
[CppInclude("LensFile.h")]
public partial class ULensFile : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Returns interpolated distortion parameters</summary>
	public bool EvaluateDistortionParameters(float InFocus,float InZoom,FDistortionInfo OutEvaluatedValue) { return default; }
	///<summary>Returns interpolated focal length</summary>
	public bool EvaluateFocalLength(float InFocus,float InZoom,FFocalLengthInfo OutEvaluatedValue) { return default; }
	///<summary>Returns interpolated image center parameters based on input focus and zoom</summary>
	public bool EvaluateImageCenterParameters(float InFocus,float InZoom,FImageCenterInfo OutEvaluatedValue) { return default; }
	///<summary>Draws the distortion map based on evaluation point</summary>
	public bool EvaluateDistortionData(float InFocus,float InZoom,FVector2D InFilmback,ULensDistortionModelHandlerBase InLensHandler) { return default; }
	///<summary>Returns interpolated nodal point offset based on input focus and zoom</summary>
	public bool EvaluateNodalPointOffset(float InFocus,float InZoom,FNodalPointOffset OutEvaluatedValue) { return default; }
	///<summary>Whether focus encoder mapping is configured</summary>
	public bool HasFocusEncoderMapping() { return default; }
	///<summary>Returns interpolated focus based on input normalized value and mapping</summary>
	public float EvaluateNormalizedFocus(float InNormalizedValue) { return default; }
	///<summary>Whether iris encoder mapping is configured</summary>
	public bool HasIrisEncoderMapping() { return default; }
	///<summary>Returns interpolated iris based on input normalized value and mapping</summary>
	public float EvaluateNormalizedIris(float InNormalizedValue) { return default; }
	///<summary>Gets all Distortion points struct with focus, zoom and info</summary>
	public TArray<FDistortionPointInfo> GetDistortionPoints() { return default; }
	///<summary>Gets all Focal Length points struct with focus, zoom and info</summary>
	public TArray<FFocalLengthPointInfo> GetFocalLengthPoints() { return default; }
	///<summary>Gets all ST Map points struct with focus, zoom and info</summary>
	public TArray<FSTMapPointInfo> GetSTMapPoints() { return default; }
	///<summary>Gets all Image Center points struct with focus, zoom and info</summary>
	public TArray<FImageCenterPointInfo> GetImageCenterPoints() { return default; }
	///<summary>Gets all Nodal Offset points struct with focus, zoom and info</summary>
	public TArray<FNodalOffsetPointInfo> GetNodalOffsetPoints() { return default; }
	///<summary>Gets a Distortion point by given focus and zoom, if point does not exists returns false</summary>
	public bool GetDistortionPoint(float InFocus,float InZoom,FDistortionInfo OutDistortionInfo) { return default; }
	///<summary>Gets a Focal Length point by given focus and zoom, if point does not exists returns false</summary>
	public bool GetFocalLengthPoint(float InFocus,float InZoom,FFocalLengthInfo OutFocalLengthInfo) { return default; }
	///<summary>Gets a Image Center point by given focus and zoom, if point does not exists returns false</summary>
	public bool GetImageCenterPoint(float InFocus,float InZoom,FImageCenterInfo OutImageCenterInfo) { return default; }
	///<summary>Gets a Nodal Offset point by given focus and zoom, if point does not exists returns false</summary>
	public bool GetNodalOffsetPoint(float InFocus,float InZoom,FNodalPointOffset OutNodalPointOffset) { return default; }
	///<summary>Gets a ST Map point by given focus and zoom, if point does not exists returns false</summary>
	public bool GetSTMapPoint(float InFocus,float InZoom,FSTMapInfo OutSTMapInfo) { return default; }
	///<summary>Adds a distortion point in our map. If a point already exist at the location, it is updated</summary>
	public void AddDistortionPoint(float NewFocus,float NewZoom,FDistortionInfo NewPoint,FFocalLengthInfo NewFocalLength) {}
	///<summary>Adds a focal length point in our map. If a point already exist at the location, it is updated</summary>
	public void AddFocalLengthPoint(float NewFocus,float NewZoom,FFocalLengthInfo NewFocalLength) {}
	///<summary>Adds an ImageCenter point in our map. If a point already exist at the location, it is updated</summary>
	public void AddImageCenterPoint(float NewFocus,float NewZoom,FImageCenterInfo NewPoint) {}
	///<summary>Adds an NodalOffset point in our map. If a point already exist at the location, it is updated</summary>
	public void AddNodalOffsetPoint(float NewFocus,float NewZoom,FNodalPointOffset NewPoint) {}
	///<summary>Adds an STMap point in our map. If a point already exist at the location, it is updated</summary>
	public void AddSTMapPoint(float NewFocus,float NewZoom,FSTMapInfo NewPoint) {}
	///<summary>Removes a focus point</summary>
	public void RemoveFocusPoint(ELensDataCategory InDataCategory,float InFocus) {}
	///<summary>Removes a zoom point</summary>
	public void RemoveZoomPoint(ELensDataCategory InDataCategory,float InFocus,float InZoom) {}
	///<summary>Removes all points of all tables</summary>
	public void ClearAll() {}
	///<summary>Removes table associated to data category</summary>
	public void ClearData(ELensDataCategory InDataCategory) {}
	///<summary>Returns whether a category has data samples</summary>
	public bool HasSamples(ELensDataCategory InDataCategory) { return default; }
	///<summary>Returns total number of the points for given category</summary>
	public int GetTotalPointNum(ELensDataCategory InDataCategory) { return default; }
	///<summary>Lens information</summary>
	public FLensInfo LensInfo;
	///<summary>Camera feed information</summary>
	public FCameraFeedInfo CameraFeedInfo;
	///<summary>Simulcam information</summary>
	public FSimulcamInfo SimulcamInfo;
	///<summary>Type of data used for lens mapping</summary>
	public ELensDataMode DataMode;
	///<summary>Metadata user could enter for its lens</summary>
	public TMap<string,string> UserMetadata;
	///<summary>Encoder mapping table</summary>
	public FEncodersTable EncodersTable;
	///<summary>Distortion parameters table mapping to input focus/zoom</summary>
	public FDistortionTable DistortionTable;
	///<summary>Focal length table mapping to input focus/zoom</summary>
	public FFocalLengthTable FocalLengthTable;
	///<summary>Image center table mapping to input focus/zoom</summary>
	public FImageCenterTable ImageCenterTable;
	///<summary>Nodal offset table mapping to input focus/zoom</summary>
	public FNodalOffsetTable NodalOffsetTable;
	///<summary>STMap table mapping to input focus/zoom</summary>
	public FSTMapTable STMapTable;
	///<summary>Importing data and options used for importing ulens files.</summary>
	public UAssetImportData AssetImportData;
	///<summary>Texture used to store temporary undistortion displacement map when using map blending</summary>
	public TArray<UTextureRenderTarget2D> UndistortionDisplacementMapHolders;
	///<summary>Texture used to store temporary distortion displacement map when using map blending</summary>
	public TArray<UTextureRenderTarget2D> DistortionDisplacementMapHolders;
}
