#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTypes.h")]
///<summary>Gives feedback as to whether the AR data can be saved and relocalized or not</summary>
public enum EARWorldMappingState {
	NotAvailable=0,
	StillMappingNotRelocalizable=1,
	StillMappingRelocalizable=2,
	Mapped=3,
}
