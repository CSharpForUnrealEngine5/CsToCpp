namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVR/DMXMVRAssetImportData.h")]
public partial class UDMXMVRAssetImportData : UAssetImportData {
	public static UClass StaticClass() {return default;}
	///<summary>The imported file path and name</summary>
	public string FilePathAndName;
	///<summary>The raw source file as byte array, as it was imported</summary>
	public FDMXByteArray64 RawSourceData;
}
