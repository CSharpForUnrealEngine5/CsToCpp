#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An actor net channel override, for hooking ReceivedBunch, to aid in detecting/blocking of remote actors, of a specific class</summary>
[CppInclude("Net/UnitTestActorChannel.h")]
public partial class UUnitTestActorChannel : UActorChannel {
	///<summary>Cached referenced to the minimal client that owns this actor channel</summary>
	public UMinimalClient MinClient;
}
