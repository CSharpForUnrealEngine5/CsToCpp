namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintPlatformLibrary.h")]
///<summary>The list of possible device/screen orientation for mobile devices</summary>
[CppEnumInNamespace]
public enum EScreenOrientation {
	Unknown=0,
	Portrait=1,
	PortraitUpsideDown=2,
	LandscapeLeft=3,
	LandscapeRight=4,
	FaceUp=5,
	FaceDown=6,
	PortraitSensor=7,
	LandscapeSensor=8,
	FullSensor=9,
}
