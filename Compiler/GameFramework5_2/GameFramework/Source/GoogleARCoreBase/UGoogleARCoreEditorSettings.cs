#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class used to expose FGoogleARCoreSessionConfig setting in the Editor plugin settings.</summary>
[CppInclude("GoogleARCoreTypes.h")]
public partial class UGoogleARCoreEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Check this option if you app require ARCore to run on Android.</summary>
	public bool bARCoreRequiredApp;
}
