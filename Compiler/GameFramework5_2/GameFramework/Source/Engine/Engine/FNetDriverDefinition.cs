#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for describing various types of netdrivers available to the engine</summary>
[CppInclude("Engine/Engine.h")]
public partial struct FNetDriverDefinition {
	public string DefName;
	public string DriverClassName;
	public string DriverClassNameFallback;
	public int MaxChannelsOverride;
}
