#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeEditorObject.h")]
public enum ELandscapeImportHeightmapError {
	None=0,
	FileNotFound=1,
	InvalidSize=2,
	CorruptFile=3,
	ColorPng=4,
	LowBitDepth=5,
}
