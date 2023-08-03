#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the AvfMedia plug-in.</summary>
[CppInclude("AvfMediaSettings.h")]
public partial class UAvfMediaSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Play audio tracks via the operating system&#39;s native sound mixer.</summary>
	public bool NativeAudioOut;
}
