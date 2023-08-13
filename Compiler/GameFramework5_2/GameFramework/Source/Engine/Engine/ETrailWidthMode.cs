namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Controls the way that the width scale property affects animation trails.</summary>
public enum ETrailWidthMode {
	ETrailWidthMode_FromCentre=0,
	ETrailWidthMode_FromFirst=1,
	ETrailWidthMode_FromSecond=2,
}
