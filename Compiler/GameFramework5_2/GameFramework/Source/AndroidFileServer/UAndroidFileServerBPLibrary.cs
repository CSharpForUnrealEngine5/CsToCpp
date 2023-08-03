#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AndroidFileServerBPLibrary.h")]
public partial class UAndroidFileServerBPLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Request startup of Android FileServer</summary>
	public static bool StartFileServer(bool bUSB/*=true*/,bool bNetwork/*=false*/,int Port/*=57099*/) { return default; }
	///<summary>Request termination of Android FileServer</summary>
	public static bool StopFileServer(bool bUSB/*=true*/,bool bNetwork/*=true*/) { return default; }
	///<summary>Check if Android FileServer is running</summary>
	public static EAFSActiveType IsFileServerRunning() { return default; }
}
