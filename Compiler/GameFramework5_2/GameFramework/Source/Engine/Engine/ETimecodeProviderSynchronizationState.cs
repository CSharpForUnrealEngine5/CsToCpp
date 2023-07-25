#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TimecodeProvider.h")]
///<summary>Possible states of TimecodeProvider.</summary>
public enum ETimecodeProviderSynchronizationState {
	Closed=0,
	Error=1,
	Synchronized=2,
	Synchronizing=3,
}
