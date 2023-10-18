namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for describing various types of netdrivers available to the engine</summary>
[CppInclude("Engine/Engine.h")]
public partial struct FNetDriverDefinition {
	public FName DefName;
	public FName DriverClassName;
	public FName DriverClassNameFallback;
	public int MaxChannelsOverride;
}
