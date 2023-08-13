namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionFloatConstant.h")]
public partial class UDistributionFloatConstant : UDistributionFloat {
	public static UClass StaticClass() {return default;}
	///<summary>This float will be returned for all values of time.</summary>
	public float Constant;
}
