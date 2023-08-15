namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A container that controls visibility based on Input type and Platform</summary>
[CppInclude("CommonVisibilityWidgetBase.h")]
public partial class UDEPRECATED_UCommonVisibilityWidgetBase : UCommonBorder {
	public static UClass StaticClass() {return default;}
	///<summary>VisibilityControls</summary>
	public TMap<FName,bool> VisibilityControls;
	///<summary>bShowForGamepad</summary>
	public bool bShowForGamepad;
	///<summary>bShowForMouseAndKeyboard</summary>
	public bool bShowForMouseAndKeyboard;
	///<summary>bShowForTouch</summary>
	public bool bShowForTouch;
	///<summary>VisibleType</summary>
	public ESlateVisibility VisibleType;
	///<summary>HiddenType</summary>
	public ESlateVisibility HiddenType;
	///<summary>GetRegisteredPlatforms</summary>
	public static TArray<FName> GetRegisteredPlatforms() { return default; }
}
