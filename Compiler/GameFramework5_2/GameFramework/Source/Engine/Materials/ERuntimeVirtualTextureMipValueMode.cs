#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionRuntimeVirtualTextureSample.h")]
///<summary>Set how Mip levels are calculated.</summary>
public enum ERuntimeVirtualTextureMipValueMode {
	RVTMVM_None=0,
	RVTMVM_MipLevel=1,
	RVTMVM_MipBias=2,
	RVTMVM_RecalculateDerivatives=3,
	RVTMVM_MAX=4,
}
