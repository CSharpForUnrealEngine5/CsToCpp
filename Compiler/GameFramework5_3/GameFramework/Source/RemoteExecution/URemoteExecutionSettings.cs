namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteExecutionSettings.h")]
public partial class URemoteExecutionSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The remote executor we prefer to use.</summary>
	public string PreferredRemoteExecutor;
}
