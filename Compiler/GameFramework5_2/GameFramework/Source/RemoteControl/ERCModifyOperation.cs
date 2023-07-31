#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IRemoteControlModule.h")]
///<summary>Type of operation to perform when setting a remote property&#39;s value</summary>
public enum ERCModifyOperation {
	EQUAL=0,
	ADD=1,
	SUBTRACT=2,
	MULTIPLY=3,
	DIVIDE=4,
}
