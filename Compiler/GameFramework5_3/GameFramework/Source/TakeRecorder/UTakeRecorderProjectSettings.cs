namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Universal take recorder settings that apply to a whole take</summary>
[CppInclude("TakeRecorderSettings.h")]
public partial class UTakeRecorderProjectSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public FTakeRecorderProjectParameters Settings;
}
