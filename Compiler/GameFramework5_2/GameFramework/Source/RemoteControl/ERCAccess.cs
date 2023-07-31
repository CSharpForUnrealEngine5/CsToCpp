#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IRemoteControlModule.h")]
///<summary>Requested access mode to a remote property</summary>
public enum ERCAccess {
	NO_ACCESS=0,
	READ_ACCESS=1,
	WRITE_ACCESS=2,
	WRITE_TRANSACTION_ACCESS=3,
	WRITE_MANUAL_TRANSACTION_ACCESS=4,
}
