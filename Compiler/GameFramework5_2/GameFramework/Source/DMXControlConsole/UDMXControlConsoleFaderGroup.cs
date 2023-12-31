namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Group of Faders in the DMX Control Console</summary>
[CppInclude("DMXControlConsoleFaderGroup.h")]
public partial class UDMXControlConsoleFaderGroup : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Name identifier of this Fader Group</summary>
	public string FaderGroupName;
	///<summary>Fixture Patch this Fader Group is based on</summary>
	public TSoftObjectPtr<UDMXEntityFixturePatch> SoftFixturePatchPtr;
	///<summary>Cached fixture patch for faster access</summary>
	public TWeakObjectPtr<UDMXEntityFixturePatch> CachedWeakFixturePatch;
	///<summary>Elements in this Fader Group</summary>
	public TArray<object /*Elements*/> Elements;
	///<summary>Color for Fader Group representation on the Editor</summary>
	public FLinearColor EditorColor;
}
