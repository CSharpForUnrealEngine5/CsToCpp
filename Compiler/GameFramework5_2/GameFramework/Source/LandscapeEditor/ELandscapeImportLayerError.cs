namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeEditorObject.h")]
public enum ELandscapeImportLayerError {
	None=0,
	MissingLayerInfo=1,
	FileNotFound=2,
	FileSizeMismatch=3,
	CorruptFile=4,
	ColorPng=5,
}
