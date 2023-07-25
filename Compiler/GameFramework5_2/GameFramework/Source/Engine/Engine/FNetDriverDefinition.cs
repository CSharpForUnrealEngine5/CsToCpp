#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Engine.h")]
///<summary>Container for describing various types of netdrivers available to the engine</summary>
public partial struct FNetDriverDefinition {
// NetDriverDefinition
	public string DefName;
	public string DriverClassName;
	public string DriverClassNameFallback;
	public int MaxChannelsOverride;
}
