namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure storing Layer Data for import</summary>
[CppInclude("LandscapeProxy.h")]
public partial struct FLandscapeImportLayerInfo {
	public string LayerName;
	public ULandscapeLayerInfoObject LayerInfo;
	public string SourceFilePath;
}
