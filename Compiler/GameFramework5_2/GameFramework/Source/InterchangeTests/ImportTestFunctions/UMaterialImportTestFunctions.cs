#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/MaterialImportTestFunctions.h")]
public partial class UMaterialImportTestFunctions : UImportTestFunctionsBase {
// MaterialImportTestFunctions
	public FInterchangeTestFunctionResult CheckImportedMaterialCount(TArray<UObject> MaterialInterfaces,int ExpectedNumberOfImportedMaterials) { return default; }
	public FInterchangeTestFunctionResult CheckImportedMaterialInstanceCount(TArray<UObject> MaterialInterfaces,int ExpectedNumberOfImportedMaterialInstances) { return default; }
	public FInterchangeTestFunctionResult CheckShadingModel(UObject MaterialInterface,EMaterialShadingModel ExpectedShadingModel) { return default; }
	public FInterchangeTestFunctionResult CheckBlendMode(UObject MaterialInterface,EBlendMode ExpectedBlendMode) { return default; }
	public FInterchangeTestFunctionResult CheckIsTwoSided(UObject MaterialInterface,bool ExpectedIsTwoSided) { return default; }
	public FInterchangeTestFunctionResult CheckOpacityMaskClipValue(UObject MaterialInterface,float ExpectedOpacityMaskClipValue) { return default; }
	public FInterchangeTestFunctionResult CheckScalarParameter(UObject MaterialInterface,string ParameterName,float ExpectedParameterValue) { return default; }
	public FInterchangeTestFunctionResult CheckVectorParameter(UObject MaterialInterface,string ParameterName,FLinearColor ExpectedParameterValue) { return default; }
}
