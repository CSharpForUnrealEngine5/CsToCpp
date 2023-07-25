#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sessions/MLAdapterSession.h")]
///<summary>Container for agents that exist in the world. Ticks the agents. Finds avatars for the agents.</summary>
public partial class UMLAdapterSession : UObject {
// MLAdapterSession
	public AGameModeBase CachedGameMode;
	public UWorld CachedWorld;
	public TMap<uint,UMLAdapterAgent> AvatarToAgent;
	public TArray<UMLAdapterAgent> Agents;
	public TArray<UMLAdapterAgent> AwaitingAvatar;
}
