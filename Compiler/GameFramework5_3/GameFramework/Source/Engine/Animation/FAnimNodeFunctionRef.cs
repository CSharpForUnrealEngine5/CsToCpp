namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cached function name/ptr that is resolved at init time</summary>
[CppInclude("Animation/AnimNodeFunctionRef.h")]
public partial struct FAnimNodeFunctionRef {
	public FName ClassName;
	public FName FunctionName;
	public UClass Class;
	public UFunction Function;
}
