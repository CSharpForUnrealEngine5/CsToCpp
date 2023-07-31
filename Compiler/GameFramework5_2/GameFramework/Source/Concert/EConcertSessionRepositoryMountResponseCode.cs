#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
///<summary>Response code returned when trying to mount a session repository on the server.</summary>
public enum EConcertSessionRepositoryMountResponseCode {
	None=0,
	Mounted=1,
	AlreadyMounted=2,
	NotFound=3,
}
