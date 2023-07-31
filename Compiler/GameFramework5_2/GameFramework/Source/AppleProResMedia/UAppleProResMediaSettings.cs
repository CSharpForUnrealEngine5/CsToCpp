#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the AppleProResMedia plug-in.</summary>
[CppInclude("AppleProResMediaSettings.h")]
public partial class UAppleProResMediaSettings : UObject {
	///<summary>Number of CPU decoding threads (Set this to 0 to have the decoder spawn according to the number of processors detected in the system.).</summary>
	public int NumberOfCPUDecodingThreads;
}
