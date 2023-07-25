#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/NetDriver.h")]
///<summary>Used to specify properties of a channel type</summary>
public partial struct FChannelDefinition {
// ChannelDefinition
	public string ChannelName;
	public string ClassName;
	public UClass ChannelClass;
	public int StaticChannelIndex;
	public bool bTickOnCreate;
	public bool bServerOpen;
	public bool bClientOpen;
	public bool bInitialServer;
	public bool bInitialClient;
}
