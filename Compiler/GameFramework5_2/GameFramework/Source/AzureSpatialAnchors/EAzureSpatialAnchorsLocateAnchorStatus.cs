#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureSpatialAnchorsTypes.h")]
///<summary>Note: this must match winrt::Microsoft::Azure::SpatialAnchors::LocateAnchorStatus</summary>
public enum EAzureSpatialAnchorsLocateAnchorStatus {
	AlreadyTracked=0,
	Located=1,
	NotLocated=2,
	NotLocatedAnchorDoesNotExist=3,
}
