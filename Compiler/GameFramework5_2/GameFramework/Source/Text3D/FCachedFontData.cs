namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Text3DEngineSubsystem.h")]
public partial struct FCachedFontData {
	public UFont Font;
	public TMap<uint,FCachedFontMeshes> Meshes;
}
