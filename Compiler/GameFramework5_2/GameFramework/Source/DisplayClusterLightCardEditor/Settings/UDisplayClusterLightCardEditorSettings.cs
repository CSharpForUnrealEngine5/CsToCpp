namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor preferences unique to this user</summary>
[CppInclude("Settings/DisplayClusterLightCardEditorSettings.h")]
public partial class UDisplayClusterLightCardEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Items recently placed by the user</summary>
	public TArray<FDisplayClusterLightCardEditorRecentItem> RecentlyPlacedItems;
	///<summary>Last used projection mode user has set</summary>
	public byte ProjectionMode;
	///<summary>Last used viewport type user has set</summary>
	public byte RenderViewportType;
	///<summary>Display icons in the light card editor where applicable</summary>
	public bool bDisplayIcons;
	///<summary>Scale icon size where applicable</summary>
	public float IconScale;
}
