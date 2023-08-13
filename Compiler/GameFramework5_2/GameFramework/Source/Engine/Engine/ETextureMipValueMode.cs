namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>defines how MipValue is used</summary>
public enum ETextureMipValueMode {
	TMVM_None=0,
	TMVM_MipLevel=1,
	TMVM_MipBias=2,
	TMVM_Derivative=3,
	TMVM_MAX=4,
}
