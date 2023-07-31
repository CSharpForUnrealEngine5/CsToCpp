#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A recording source that records world state</summary>
[CppInclude("TakeRecorderWorldSource.h")]
public partial class UTakeRecorderWorldSourceSettings : UTakeRecorderSource {
	///<summary>Record world settings</summary>
	public bool bRecordWorldSettings;
	///<summary>Add a binding and track for all actors that aren&#39;t explicitly being recorded</summary>
	public bool bAutotrackActors;
}
