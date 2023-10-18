namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeEditorObject.h")]
public partial struct FLandscapeImportLayer {
	public ULandscapeMaterialInstanceConstant ThumbnailMIC;
	public ELandscapeImportResult ImportResult;
	public FText ErrorMessage;
	public string ExportFilePath;
	public bool bSelected;
}
