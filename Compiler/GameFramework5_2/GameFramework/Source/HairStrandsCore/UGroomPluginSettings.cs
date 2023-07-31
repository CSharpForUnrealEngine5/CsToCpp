#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the groom plug-in</summary>
[CppInclude("GroomPluginSettings.h")]
public partial class UGroomPluginSettings : UObject {
	///<summary>The amount of groom cache animation (in seconds) to pre-load ahead of time by the streaming manager</summary>
	public float GroomCacheLookAheadBuffer;
}
