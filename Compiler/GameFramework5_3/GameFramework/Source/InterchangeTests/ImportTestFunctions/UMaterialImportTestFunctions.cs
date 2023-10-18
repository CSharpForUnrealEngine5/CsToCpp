namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/MaterialImportTestFunctions.h")]
public partial class UMaterialImportTestFunctions : UImportTestFunctionsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Check whether the expected number of materials are imported</summary>
	public static FInterchangeTestFunctionResult CheckImportedMaterialCount(TArray<UMaterialInterface> MaterialInterfaces,int ExpectedNumberOfImportedMaterials) { return default; }
	///<summary>Check whether the expected number of material instances are imported</summary>
	public static FInterchangeTestFunctionResult CheckImportedMaterialInstanceCount(TArray<UMaterialInterface> MaterialInterfaces,int ExpectedNumberOfImportedMaterialInstances) { return default; }
	///<summary>Check whether the imported material has the expected shading model</summary>
	public static FInterchangeTestFunctionResult CheckShadingModel(UMaterialInterface MaterialInterface,EMaterialShadingModel ExpectedShadingModel) { return default; }
	///<summary>Check whether the imported material has the expected blend mode</summary>
	public static FInterchangeTestFunctionResult CheckBlendMode(UMaterialInterface MaterialInterface,EBlendMode ExpectedBlendMode) { return default; }
	///<summary>Check whether the imported material has the expected two-sided setting</summary>
	public static FInterchangeTestFunctionResult CheckIsTwoSided(UMaterialInterface MaterialInterface,bool ExpectedIsTwoSided) { return default; }
	///<summary>Check whether the imported material has the expected opacity mask clip value</summary>
	public static FInterchangeTestFunctionResult CheckOpacityMaskClipValue(UMaterialInterface MaterialInterface,float ExpectedOpacityMaskClipValue) { return default; }
	///<summary>Check whether the imported material has the expected scalar parameter value</summary>
	public static FInterchangeTestFunctionResult CheckScalarParameter(UMaterialInterface MaterialInterface,string ParameterName,float ExpectedParameterValue) { return default; }
	///<summary>Check whether the imported material has the expected vector parameter value</summary>
	public static FInterchangeTestFunctionResult CheckVectorParameter(UMaterialInterface MaterialInterface,string ParameterName,FLinearColor ExpectedParameterValue) { return default; }
}
