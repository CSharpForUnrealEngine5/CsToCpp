namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/AssetImportTestFunctions.h")]
public partial class UAssetImportTestFunctions : UImportTestFunctionsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Check whether the expected number of metadata for the object are imported</summary>
	public static FInterchangeTestFunctionResult CheckImportedMetadataCount(UObject Object,int ExpectedNumberOfMetadataForThisObject) { return default; }
	///<summary>Check whether the expected object metadata key exist.</summary>
	public static FInterchangeTestFunctionResult CheckMetadataExist(UObject Object,string ExpectedMetadataKey) { return default; }
	///<summary>Check whether the expected object metadata value is imported.</summary>
	public static FInterchangeTestFunctionResult CheckMetadataValue(UObject Object,string ExpectedMetadataKey,string ExpectedMetadataValue) { return default; }
}
