namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureSpatialAnchorsTypes.h")]
///<summary>Note: this must match winrt::Microsoft::Azure::SpatialAnchors::SessionLogLevel</summary>
public enum EAzureSpatialAnchorsLogVerbosity {
	None=0,
	Error=1,
	Warning=2,
	Information=3,
	Debug=4,
	All=5,
}
