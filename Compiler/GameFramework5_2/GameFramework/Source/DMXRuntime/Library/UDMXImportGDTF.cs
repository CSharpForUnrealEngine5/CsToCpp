#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXImportGDTF.h")]
public partial class UDMXImportGDTF : UDMXImport {
	///<summary>GetDMXModes</summary>
	public  UDMXImportGDTFDMXModes GetDMXModes() { return default; }
	///<summary>DEPRECATED 5.1 in favor of AssetImportData</summary>
	public string SourceFilename_DEPRECATED;
	///<summary>The Asset Import Data used to generate the GDTF asset or nullptr, if not generated from a GDTF file</summary>
	public UDMXGDTFAssetImportData GDTFAssetImportData;
}
