#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cached function name/ptr that is resolved at init time</summary>
[CppInclude("Animation/AnimNodeFunctionRef.h")]
public partial struct FAnimNodeFunctionRef {
	public string ClassName;
	public string FunctionName;
	public UClass Class;
	public UFunction Function;
}
