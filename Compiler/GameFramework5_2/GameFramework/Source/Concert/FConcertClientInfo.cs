#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessageData.h")]
///<summary>Holds info on a client connected through concert</summary>
public partial struct FConcertClientInfo {
// ConcertClientInfo
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
