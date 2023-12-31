namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A struct to specify the domain range of a resource buffer, as defined by compute kernels and data</summary>
[CppInclude("OptimusDataDomain.h")]
public partial struct FOptimusDataDomain {
	public EOptimusDataDomainType Type;
	public TArray<FName> DimensionNames;
	public int Multiplier;
	public string Expression;
	public TArray<FName> LevelNames_DEPRECATED;
}
