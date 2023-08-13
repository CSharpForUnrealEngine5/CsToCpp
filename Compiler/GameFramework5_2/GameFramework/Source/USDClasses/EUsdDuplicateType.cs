namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDDuplicateType.h")]
///<summary>Describes the different types of &quot;prim duplication&quot; operations we support with UsdUtils::DuplicatePrims</summary>
public enum EUsdDuplicateType {
	FlattenComposedPrim=0,
	SingleLayerSpecs=1,
	AllLocalLayerSpecs=2,
}
