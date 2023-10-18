namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OodleNetworkHandlerComponent.h")]
///<summary>Specifies when compression is enabled. Used to make compression optional, for some platforms/clients</summary>
public enum EOodleNetworkEnableMode {
	AlwaysEnabled=0,
	WhenCompressedPacketReceived=1,
}
