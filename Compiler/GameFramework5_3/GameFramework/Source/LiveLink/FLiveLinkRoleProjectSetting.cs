namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for LiveLinkRole.</summary>
[CppInclude("LiveLinkSettings.h")]
public partial struct FLiveLinkRoleProjectSetting {
	public UClass Role;
	public UClass SettingClass;
	public UClass FrameInterpolationProcessor;
	public TArray<UClass> FramePreProcessors;
}
