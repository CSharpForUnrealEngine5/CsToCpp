namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXGDTFAssetImportData.h")]
public partial class UDMXGDTFAssetImportData : UAssetImportData {
	public static UClass StaticClass() {return default;}
	///<summary>The imported file path and name</summary>
	public string FilePathAndName;
	///<summary>The raw GDTF zip file as byte array</summary>
	public FDMXByteArray64 RawSourceData;
}
