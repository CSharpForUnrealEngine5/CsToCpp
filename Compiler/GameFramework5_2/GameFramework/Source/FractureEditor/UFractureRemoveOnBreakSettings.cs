#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolProperties.h")]
public partial class UFractureRemoveOnBreakSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>whether or not the remove on fracture is enabled</summary>
	public bool Enabled;
	///<summary>Min/Max time after break before removal starts</summary>
	public FVector2f PostBreakTimer;
	///<summary>When set, clusters will crumble when post break timer expires, non clusters will simply use the removal timer</summary>
	public bool ClusterCrumbling;
	///<summary>Min/Max time for how long removal lasts - not applicable when cluster crumbling is on</summary>
	public FVector2f RemovalTimer;
	///<summary>remove the remove on break attribute from the geometry collection, usefull to save memory on the asset if not needed</summary>
	public  void DeleteRemoveOnBreakData() {}
}
