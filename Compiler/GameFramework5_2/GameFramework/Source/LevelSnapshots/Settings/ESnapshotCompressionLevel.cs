namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/SnapshotCompressionSettings.h")]
///<summary>ESnapshotCompressionLevel and ESnapshotCompressor copied from OodleDataCompression.h - there is no UENUM version at time of duplication</summary>
public enum ESnapshotCompressionLevel {
	HyperFast4=-4,
	HyperFast3=-3,
	HyperFast2=-2,
	HyperFast1=-1,
	None=0,
	SuperFast=1,
	VeryFast=2,
	Fast=3,
	Normal=4,
	Optimal1=5,
	Optimal2=6,
	Optimal3=7,
	Optimal4=8,
}
