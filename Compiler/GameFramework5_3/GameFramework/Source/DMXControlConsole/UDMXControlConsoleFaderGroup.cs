namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Group of Faders in the DMX Control Console</summary>
[CppInclude("DMXControlConsoleFaderGroup.h")]
public partial class UDMXControlConsoleFaderGroup : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Last string from Editor filtering</summary>
	public string FilterString;
	///<summary>Name identifier of this Fader Group</summary>
	public string FaderGroupName;
	///<summary>Fixture Patch this Fader Group is based on</summary>
	public TSoftObjectPtr<UDMXEntityFixturePatch> SoftFixturePatchPtr;
	///<summary>Cached fixture patch for faster access</summary>
	public TWeakObjectPtr<UDMXEntityFixturePatch> CachedWeakFixturePatch;
	///<summary>Elements in this Fader Group</summary>
	public TArray<object /*Elements*/> Elements;
	///<summary>If true, the Fader Group doesn&#39;t send DMX</summary>
	public bool bIsMuted;
	///<summary>Color for Fader Group representation on the Editor</summary>
	public FLinearColor EditorColor;
	///<summary>Fader Group expansion state saved from the Editor</summary>
	public bool bIsExpanded;
	///<summary>In Editor activity state of the Fader Group</summary>
	public bool bIsActive;
}
