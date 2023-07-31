#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXGDTFAssetImportData.h")]
public partial class UDMXGDTFAssetImportData : UAssetImportData {
	///<summary>The imported file path and name</summary>
	public string FilePathAndName;
	///<summary>The raw GDTF zip file as byte array</summary>
	public FDMXByteArray64 RawSourceData;
}
