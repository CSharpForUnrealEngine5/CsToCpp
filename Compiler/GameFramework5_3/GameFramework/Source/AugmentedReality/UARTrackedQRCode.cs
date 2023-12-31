namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARTrackedQRCode : UARTrackedImage {
	public static UClass StaticClass() {return default;}
	///<summary>The encoded information in the qr code</summary>
	public string QRCode;
	///<summary>The version of the qr code</summary>
	public int Version;
}
