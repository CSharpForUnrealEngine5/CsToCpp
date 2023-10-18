namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeStreamingProxy.h")]
public partial class ALandscapeStreamingProxy : ALandscapeProxy {
	public static UClass StaticClass() {return default;}
	///<summary>LandscapeActor_DEPRECATED</summary>
	public TLazyObjectPtr<ALandscape> LandscapeActor_DEPRECATED;
	///<summary>LandscapeActorRef</summary>
	public TSoftObjectPtr<ALandscape> LandscapeActorRef;
	///<summary>OverriddenSharedProperties</summary>
	public TSet<string> OverriddenSharedProperties;
}
