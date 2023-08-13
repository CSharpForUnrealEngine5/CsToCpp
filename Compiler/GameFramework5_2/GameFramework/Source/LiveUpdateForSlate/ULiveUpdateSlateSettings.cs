namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveUpdateSlateSettings.h")]
public partial class ULiveUpdateSlateSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Refreshes the editor&#39;s Slate layout when Live Coding patches are complete.</summary>
	public bool bEnableLiveUpdateForSlate;
}
