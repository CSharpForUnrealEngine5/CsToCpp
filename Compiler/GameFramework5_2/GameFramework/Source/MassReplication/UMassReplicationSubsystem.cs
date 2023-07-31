#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Manages the creation of NetworkIDs, ClientBubbles and ClientReplicationInfo.</summary>
[CppInclude("MassReplicationSubsystem.h")]
public partial class UMassReplicationSubsystem : UWorldSubsystem {
	///<summary>BubbleInfoArray</summary>
	public TArray<FMassClientBubbleInfoData> BubbleInfoArray;
	///<summary>World</summary>
	public UWorld World;
	///<summary>MassLODSubsystem</summary>
	public UMassLODSubsystem MassLODSubsystem;
}
