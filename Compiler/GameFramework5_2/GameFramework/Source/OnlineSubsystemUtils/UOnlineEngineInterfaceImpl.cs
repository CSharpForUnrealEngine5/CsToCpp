namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnlineEngineInterfaceImpl.h")]
public partial class UOnlineEngineInterfaceImpl : UOnlineEngineInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Mapping of unique net ids that should not be treated as foreign ids to the local subsystem.</summary>
	public TMap<string,string> MappedUniqueNetIdTypes;
	///<summary>Array of unique net ids that are deemed valid when tested against gameplay login checks.</summary>
	public TArray<string> CompatibleUniqueNetIdTypes;
	///<summary>Allow the subsystem used for voice functions to be overridden, in case it needs to be different than the default subsystem. May be useful on console platforms.</summary>
	public string VoiceSubsystemNameOverride;
}
