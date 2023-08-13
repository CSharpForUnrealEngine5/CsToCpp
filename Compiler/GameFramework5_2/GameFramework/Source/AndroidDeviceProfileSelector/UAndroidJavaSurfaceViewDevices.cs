namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AndroidJavaSurfaceViewDevices.h")]
public partial class UAndroidJavaSurfaceViewDevices : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Array of devices that require the java view scaling workaround</summary>
	public TArray<FJavaSurfaceViewDevice> SurfaceViewDevices;
}
