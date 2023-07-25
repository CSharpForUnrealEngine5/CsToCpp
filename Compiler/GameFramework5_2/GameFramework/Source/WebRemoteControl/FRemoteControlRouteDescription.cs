#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRoute.h")]
///<summary>Utility struct to create a textual representation of an http route.</summary>
public partial struct FRemoteControlRouteDescription {
// RemoteControlRouteDescription
	public string Path;
	public ERemoteControlHttpVerbs Verb;
	public string Description;
}
