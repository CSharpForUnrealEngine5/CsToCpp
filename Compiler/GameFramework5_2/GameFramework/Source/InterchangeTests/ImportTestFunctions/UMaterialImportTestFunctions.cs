#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/MaterialImportTestFunctions.h")]
public partial class UMaterialImportTestFunctions : UImportTestFunctionsBase {
// MaterialImportTestFunctions
	public static FInterchangeTestFunctionResult CheckImportedMaterialCount(TArray<UMaterialInterface> MaterialInterfaces,int ExpectedNumberOfImportedMaterials) { return default; }
	public static FInterchangeTestFunctionResult CheckImportedMaterialInstanceCount(TArray<UMaterialInterface> MaterialInterfaces,int ExpectedNumberOfImportedMaterialInstances) { return default; }
	public static FInterchangeTestFunctionResult CheckShadingModel(UMaterialInterface MaterialInterface,EMaterialShadingModel ExpectedShadingModel) { return default; }
	public static FInterchangeTestFunctionResult CheckBlendMode(UMaterialInterface MaterialInterface,EBlendMode ExpectedBlendMode) { return default; }
	public static FInterchangeTestFunctionResult CheckIsTwoSided(UMaterialInterface MaterialInterface,bool ExpectedIsTwoSided) { return default; }
	public static FInterchangeTestFunctionResult CheckOpacityMaskClipValue(UMaterialInterface MaterialInterface,float ExpectedOpacityMaskClipValue) { return default; }
	public static FInterchangeTestFunctionResult CheckScalarParameter(UMaterialInterface MaterialInterface,string ParameterName,float ExpectedParameterValue) { return default; }
	public static FInterchangeTestFunctionResult CheckVectorParameter(UMaterialInterface MaterialInterface,string ParameterName,FLinearColor ExpectedParameterValue) { return default; }
}
