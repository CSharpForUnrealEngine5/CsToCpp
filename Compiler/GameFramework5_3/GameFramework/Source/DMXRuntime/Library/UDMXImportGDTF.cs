namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXImportGDTF.h")]
public partial class UDMXImportGDTF : UDMXImport {
	public static UClass StaticClass() {return default;}
	///<summary>GetDMXModes</summary>
	public UDMXImportGDTFDMXModes GetDMXModes() { return default; }
	///<summary>DEPRECATED 5.1 in favor of AssetImportData</summary>
	public string SourceFilename_DEPRECATED;
	///<summary>The Asset Import Data used to generate the GDTF asset or nullptr, if not generated from a GDTF file</summary>
	public UDMXGDTFAssetImportData GDTFAssetImportData;
}
