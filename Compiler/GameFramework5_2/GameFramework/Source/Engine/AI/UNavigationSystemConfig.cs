namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/NavigationSystemConfig.h")]
public partial class UNavigationSystemConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>NavigationSystemClass</summary>
	public FSoftClassPath NavigationSystemClass;
	///<summary>NavigationSystem&#39;s properties in Project Settings define all possible supported agents,</summary>
	public FNavAgentSelector SupportedAgentsMask;
	///<summary>If not None indicates which of navigation datas and supported agents are</summary>
	public string DefaultAgentName;
	///<summary>If true it means the navigation system settings are overridden from another source (like a NavConfigOverrideActor)</summary>
	public bool bIsOverriden;
}
