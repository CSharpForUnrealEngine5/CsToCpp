namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility struct to create a textual representation of an http route.</summary>
[CppInclude("RemoteControlRoute.h")]
public partial struct FRemoteControlRouteDescription {
	public string Path;
	public ERemoteControlHttpVerbs Verb;
	public string Description;
}
