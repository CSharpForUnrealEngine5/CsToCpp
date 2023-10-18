namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/RuntimeHashSet/RuntimePartition.h")]
public partial class URuntimePartition : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Name</summary>
	public FName Name;
	///<summary>bBlockOnSlowStreaming</summary>
	public bool bBlockOnSlowStreaming;
	///<summary>bClientOnlyVisible</summary>
	public bool bClientOnlyVisible;
	///<summary>Priority</summary>
	public int Priority;
	///<summary>bIsHLODSetup</summary>
	public bool bIsHLODSetup;
}
