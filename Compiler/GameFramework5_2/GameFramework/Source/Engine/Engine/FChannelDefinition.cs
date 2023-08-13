namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to specify properties of a channel type</summary>
[CppInclude("Engine/NetDriver.h")]
public partial struct FChannelDefinition {
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
