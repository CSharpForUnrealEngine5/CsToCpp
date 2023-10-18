namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuR/System.h")]
///<summary>Despite being an UEnum, this is not always version-serialized (in MutableTools).</summary>
public enum ETextureCompressionStrategy {
	None=0,
	DontCompressRuntime=1,
	NeverCompress=2,
}
