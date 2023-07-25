#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithVREDImportOptions.h")]
public partial class UDatasmithVREDImportOptions : UDatasmithFBXImportOptions {
// DatasmithVREDImportOptions
	public bool bImportMats;
	public FFilePath MatsPath;
	public bool bImportVar;
	public bool bCleanVar;
	public FFilePath VarPath;
	public bool bImportLightInfo;
	public FFilePath LightInfoPath;
	public bool bImportClipInfo;
	public FFilePath ClipInfoPath;
}
