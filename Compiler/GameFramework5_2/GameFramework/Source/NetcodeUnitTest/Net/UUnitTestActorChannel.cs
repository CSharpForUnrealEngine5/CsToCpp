#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/UnitTestActorChannel.h")]
///<summary>An actor net channel override, for hooking ReceivedBunch, to aid in detecting/blocking of remote actors, of a specific class</summary>
public partial class UUnitTestActorChannel : UActorChannel {
// UnitTestActorChannel
	public UMinimalClient MinClient;
}
