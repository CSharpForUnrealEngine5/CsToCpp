#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AndroidRuntimeSettings.h")]
///<summary>IF THIS CHANGES, MAKE SURE TO UPDATE UEDeployAndroid.cs, ConvertOrientationIniValue()!</summary>
[CppEnumInNamespace]
public enum EAndroidScreenOrientation {
	Portrait=0,
	ReversePortrait=1,
	SensorPortrait=2,
	Landscape=3,
	ReverseLandscape=4,
	SensorLandscape=5,
	Sensor=6,
	FullSensor=7,
}
