namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for raw (baked out) Distribution type</summary>
[CppInclude("Distributions/Distribution.h")]
public partial struct FRawDistribution {
	public FDistributionLookupTable Table;
}
