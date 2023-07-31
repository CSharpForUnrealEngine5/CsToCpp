#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeEditorObject.h")]
public partial struct FLandscapeImportLayer {
	public ULandscapeMaterialInstanceConstant ThumbnailMIC;
	public ELandscapeImportResult ImportResult;
	public string ErrorMessage;
	public string ExportFilePath;
	public bool bSelected;
}
