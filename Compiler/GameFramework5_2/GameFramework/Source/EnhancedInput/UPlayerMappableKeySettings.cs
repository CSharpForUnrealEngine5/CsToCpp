#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Hold setting information of an Action Input or a Action Key Mapping for setting screen and save purposes.</summary>
[CppInclude("PlayerMappableKeySettings.h")]
public partial class UPlayerMappableKeySettings : UObject {
	///<summary>Metadata that can used to store any other related items to this key mapping such as icons, ability assets, etc.</summary>
	public UObject Metadata;
	///<summary>A unique name for this player mapping to be saved with.</summary>
	public string Name;
	///<summary>The localized display name of this key mapping. Use this when displaying the mappings to a user.</summary>
	public string DisplayName;
	///<summary>The category that this player mapping is in</summary>
	public string DisplayCategory;
}
