namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A description of an actor that can both uniquely identify it and provide a user-friendly name.</summary>
[CppInclude("RemoteControlModels.h")]
public partial struct FRCActorDescription {
	public string Name;
	public string Path;
}
