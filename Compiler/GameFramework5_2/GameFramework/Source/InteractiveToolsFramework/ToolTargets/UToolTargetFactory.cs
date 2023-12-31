namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for factories of tool targets, which let a tool manager build targets</summary>
[CppInclude("ToolTargets/ToolTarget.h")]
public partial class UToolTargetFactory : UObject {
	public static UClass StaticClass() {return default;}
}
