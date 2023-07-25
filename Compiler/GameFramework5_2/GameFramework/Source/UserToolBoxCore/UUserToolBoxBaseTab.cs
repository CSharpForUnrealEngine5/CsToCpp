#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UTBBaseTab.h")]
///<summary>UUserToolBoxBaseTab is the class that represent a configurable tab</summary>
public partial class UUserToolBoxBaseTab : UDataAsset {
// UserToolBoxBaseTab
	public string Name;
	public UClass TabUI;
	public UClass DefaultCommandUIOverride;
	public bool IsSettingShouldBeVisible;
	public bool bIsVisibleInViewportOverlay;
	public bool bIsVisibleInDrawer;
	public bool bIsVisibleInWindowsMenu;
	public TArray<UUTBTabSection> Sections;
	public UUTBTabSection PlaceholderSection;
}
