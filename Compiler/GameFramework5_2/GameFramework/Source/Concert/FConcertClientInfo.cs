#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds info on a client connected through concert</summary>
[CppInclude("ConcertMessageData.h")]
public partial struct FConcertClientInfo {
	public FConcertInstanceInfo InstanceInfo;
	public string DeviceName;
	public string PlatformName;
	public string UserName;
	public string DisplayName;
	public FLinearColor AvatarColor;
	public string DesktopAvatarActorClass;
	public string VRAvatarActorClass;
	public TArray<string> Tags;
	public bool bHasEditorData;
	public bool bRequiresCookedData;
}
