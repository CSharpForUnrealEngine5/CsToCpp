#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AndroidFileServerBPLibrary.h")]
public partial class UAndroidFileServerBPLibrary : UBlueprintFunctionLibrary {
// AndroidFileServerBPLibrary
	public bool StartFileServer(bool bUSB/*=true*/,bool bNetwork/*=false*/,int Port/*=57099*/) { return default; }
	public bool StopFileServer(bool bUSB/*=true*/,bool bNetwork/*=true*/) { return default; }
	public byte IsFileServerRunning() { return default; }
}
