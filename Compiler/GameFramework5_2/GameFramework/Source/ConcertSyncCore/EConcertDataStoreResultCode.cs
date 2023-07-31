#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertDataStoreMessages.h")]
///<summary>Response codes for Concert data store operations.</summary>
public enum EConcertDataStoreResultCode {
	Added=0,
	Fetched=1,
	Exchanged=2,
	NotFound=3,
	TypeMismatch=4,
	UnexpectedError=5,
}
