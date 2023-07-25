#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDDuplicateType.h")]
///<summary>Describes the different types of "prim duplication" operations we support with UsdUtils::DuplicatePrims</summary>
public enum EUsdDuplicateType {
	FlattenComposedPrim=0,
	SingleLayerSpecs=1,
	AllLocalLayerSpecs=2,
}
