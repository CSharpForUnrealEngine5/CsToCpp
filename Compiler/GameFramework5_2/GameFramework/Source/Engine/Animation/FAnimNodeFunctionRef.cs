#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNodeFunctionRef.h")]
///<summary>Cached function name/ptr that is resolved at init time</summary>
public partial struct FAnimNodeFunctionRef {
// AnimNodeFunctionRef
	public string ClassName;
	public string FunctionName;
	public UClass Class;
	public UFunction Function;
}
