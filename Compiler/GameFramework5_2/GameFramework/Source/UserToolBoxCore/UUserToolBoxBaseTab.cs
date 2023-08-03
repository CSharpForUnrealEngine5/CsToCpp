#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UUserToolBoxBaseTab is the class that represent a configurable tab</summary>
[CppInclude("UTBBaseTab.h")]
public partial class UUserToolBoxBaseTab : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the toolbox</summary>
	public string Name;
	///<summary>The UI template to use to render this tab</summary>
	public UClass TabUI;
	///<summary>the default override for each command ( does not override ui command specified in the command)</summary>
	public UClass DefaultCommandUIOverride;
	///<summary>Should the setting&#39;s icon be visible on the top right of the tab ( for easy access)</summary>
	public bool IsSettingShouldBeVisible;
	///<summary>bIsVisibleInViewportOverlay</summary>
	public bool bIsVisibleInViewportOverlay;
	///<summary>bIsVisibleInDrawer</summary>
	public bool bIsVisibleInDrawer;
	///<summary>bIsVisibleInWindowsMenu</summary>
	public bool bIsVisibleInWindowsMenu;
	///<summary>the array of sections</summary>
	public TArray<UUTBTabSection> Sections;
	///<summary>the placeholder section</summary>
	public UUTBTabSection PlaceholderSection;
}
