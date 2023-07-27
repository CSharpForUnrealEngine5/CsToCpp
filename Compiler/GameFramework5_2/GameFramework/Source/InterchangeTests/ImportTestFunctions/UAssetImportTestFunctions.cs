#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/AssetImportTestFunctions.h")]
public partial class UAssetImportTestFunctions : UImportTestFunctionsBase {
// AssetImportTestFunctions
	public static FInterchangeTestFunctionResult CheckImportedMetadataCount(UObject Object,int ExpectedNumberOfMetadataForThisObject) { return default; }
	public static FInterchangeTestFunctionResult CheckMetadataExist(UObject Object,string ExpectedMetadataKey) { return default; }
	public static FInterchangeTestFunctionResult CheckMetadataValue(UObject Object,string ExpectedMetadataKey,string ExpectedMetadataValue) { return default; }
}
