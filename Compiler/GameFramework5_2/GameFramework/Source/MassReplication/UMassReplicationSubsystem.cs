#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassReplicationSubsystem.h")]
///<summary>Manages the creation of NetworkIDs, ClientBubbles and ClientReplicationInfo.</summary>
public partial class UMassReplicationSubsystem : UWorldSubsystem {
// MassReplicationSubsystem
	public TArray<FMassClientBubbleInfoData> BubbleInfoArray;
	public UWorld World;
	public UMassLODSubsystem MassLODSubsystem;
}
