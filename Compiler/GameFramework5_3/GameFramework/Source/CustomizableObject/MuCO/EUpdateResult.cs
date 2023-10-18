namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObjectInstance.h")]
///<summary>Instance Update Result.</summary>
public enum EUpdateResult {
	Success=0,
	Error=1,
	ErrorOptimized=2,
	ErrorReplaced=3,
	ErrorDiscarded=4,
}
