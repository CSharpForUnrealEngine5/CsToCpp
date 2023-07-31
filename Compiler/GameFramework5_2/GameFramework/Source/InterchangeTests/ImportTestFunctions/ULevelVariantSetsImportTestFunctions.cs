#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/LevelVariantSetsImportTestFunctions.h")]
public partial class ULevelVariantSetsImportTestFunctions : UImportTestFunctionsBase {
	///<summary>Check whether the expected number of LevelVariantSets are imported</summary>
	public static FInterchangeTestFunctionResult CheckLevelVariantSetsCount(TArray<ULevelVariantSets> LevelVariantSetsAssets,int ExpectedNumberOfLevelVariantSets) { return default; }
	///<summary>Check whether the imported LevelVariantSets has the expected number of variant sets</summary>
	public static FInterchangeTestFunctionResult CheckVariantSetsCount(ULevelVariantSets LevelVariantSets,int ExpectedNumberOfVariantSets) { return default; }
	///<summary>Check whether the imported LevelVariantSets has the expected number of variants for the given variant set</summary>
	public static FInterchangeTestFunctionResult CheckVariantsCount(ULevelVariantSets LevelVariantSets,string VariantSetName,int ExpectedNumberOfVariants) { return default; }
	///<summary>Check whether the imported LevelVariantSets has the expected number of bindings for the given variant in the given set</summary>
	public static FInterchangeTestFunctionResult CheckBindingsCount(ULevelVariantSets LevelVariantSets,string VariantSetName,string VariantName,int ExpectedNumberOfBindings) { return default; }
}
