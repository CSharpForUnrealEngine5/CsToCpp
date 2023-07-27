#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/LevelVariantSetsImportTestFunctions.h")]
public partial class ULevelVariantSetsImportTestFunctions : UImportTestFunctionsBase {
// LevelVariantSetsImportTestFunctions
	public static FInterchangeTestFunctionResult CheckLevelVariantSetsCount(TArray<ULevelVariantSets> LevelVariantSetsAssets,int ExpectedNumberOfLevelVariantSets) { return default; }
	public static FInterchangeTestFunctionResult CheckVariantSetsCount(ULevelVariantSets LevelVariantSets,int ExpectedNumberOfVariantSets) { return default; }
	public static FInterchangeTestFunctionResult CheckVariantsCount(ULevelVariantSets LevelVariantSets,string VariantSetName,int ExpectedNumberOfVariants) { return default; }
	public static FInterchangeTestFunctionResult CheckBindingsCount(ULevelVariantSets LevelVariantSets,string VariantSetName,string VariantName,int ExpectedNumberOfBindings) { return default; }
}
