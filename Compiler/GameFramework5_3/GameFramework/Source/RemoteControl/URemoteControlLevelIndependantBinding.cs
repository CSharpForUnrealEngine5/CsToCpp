namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlBinding.h")]
public partial class URemoteControlLevelIndependantBinding : URemoteControlBinding {
	public static UClass StaticClass() {return default;}
	///<summary>Holds the bound object.</summary>
	public TSoftObjectPtr<UObject> BoundObject;
}
