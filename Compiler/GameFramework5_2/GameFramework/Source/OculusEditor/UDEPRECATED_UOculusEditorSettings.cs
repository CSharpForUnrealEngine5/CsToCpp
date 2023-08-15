namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusEditorSettings.h")]
public partial class UDEPRECATED_UOculusEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>PerfToolIgnoreList</summary>
	public TMap<FName,bool> PerfToolIgnoreList;
	///<summary>PerfToolTargetPlatform</summary>
	public EOculusPlatform PerfToolTargetPlatform;
	///<summary>bAddMenuOption</summary>
	public bool bAddMenuOption;
}
