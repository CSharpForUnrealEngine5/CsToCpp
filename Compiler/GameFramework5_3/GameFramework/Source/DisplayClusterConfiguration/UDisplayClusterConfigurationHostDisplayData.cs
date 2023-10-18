namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes.h")]
public partial class UDisplayClusterConfigurationHostDisplayData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Custom name for the Host PC. No effect on nDisplay</summary>
	public FText HostName;
	///<summary>Arbitrary position of the Host PC in 2D workspace. No effect on nDisplay</summary>
	public FVector2D Position;
	///<summary>Disables the automatic placement of Host PCs</summary>
	public bool bAllowManualPlacement;
	///<summary>Resolution of Host PC in pixels</summary>
	public FVector2D HostResolution;
	///<summary>Allows to manually resize the Host PC resolution</summary>
	public bool bAllowManualSizing;
	///<summary>Specify coordinates of the Host PC origin in relation to OS configuration</summary>
	public FVector2D Origin;
	///<summary>Specify custom and arbitrary color for a given Host PC</summary>
	public FLinearColor Color;
	///<summary>bIsVisible</summary>
	public bool bIsVisible;
	///<summary>bIsUnlocked</summary>
	public bool bIsUnlocked;
}
