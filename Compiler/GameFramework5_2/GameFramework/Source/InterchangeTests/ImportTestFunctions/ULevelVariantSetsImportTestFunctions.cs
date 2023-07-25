#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/LevelVariantSetsImportTestFunctions.h")]
public partial class ULevelVariantSetsImportTestFunctions : UImportTestFunctionsBase {
// LevelVariantSetsImportTestFunctions
	public FInterchangeTestFunctionResult CheckLevelVariantSetsCount(TArray<UObject> LevelVariantSetsAssets,int ExpectedNumberOfLevelVariantSets) { return default; }
	public FInterchangeTestFunctionResult CheckVariantSetsCount(UObject LevelVariantSets,int ExpectedNumberOfVariantSets) { return default; }
	public FInterchangeTestFunctionResult CheckVariantsCount(UObject LevelVariantSets,string VariantSetName,int ExpectedNumberOfVariants) { return default; }
	public FInterchangeTestFunctionResult CheckBindingsCount(UObject LevelVariantSets,string VariantSetName,string VariantName,int ExpectedNumberOfBindings) { return default; }
}
