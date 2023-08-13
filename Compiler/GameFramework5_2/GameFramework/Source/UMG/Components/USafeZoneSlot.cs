namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SafeZoneSlot.h")]
public partial class USafeZoneSlot : UPanelSlot {
	public static UClass StaticClass() {return default;}
	///<summary>bIsTitleSafe</summary>
	public bool bIsTitleSafe;
	///<summary>SafeAreaScale</summary>
	public FMargin SafeAreaScale;
	///<summary>HAlign</summary>
	public EHorizontalAlignment HAlign;
	///<summary>VAlign</summary>
	public EVerticalAlignment VAlign;
	///<summary>Padding</summary>
	public FMargin Padding;
}
