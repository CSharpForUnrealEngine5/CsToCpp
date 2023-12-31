namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for LiveLink.</summary>
[CppInclude("LiveLinkComponentSettings.h")]
public partial class ULiveLinkComponentSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Default Controller class to use for the specified role</summary>
	public TMap<UClass,UClass> DefaultControllerForRole;
}
