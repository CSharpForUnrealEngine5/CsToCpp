namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Manages the creation of NetworkIDs, ClientBubbles and ClientReplicationInfo.</summary>
[CppInclude("MassReplicationSubsystem.h")]
public partial class UMassReplicationSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>BubbleInfoArray</summary>
	public TArray<FMassClientBubbleInfoData> BubbleInfoArray;
	///<summary>World</summary>
	public UWorld World;
	///<summary>MassLODSubsystem</summary>
	public UMassLODSubsystem MassLODSubsystem;
}
