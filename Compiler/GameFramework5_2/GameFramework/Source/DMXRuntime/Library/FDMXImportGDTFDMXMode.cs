#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXImportGDTF.h")]
public partial struct FDMXImportGDTFDMXMode {
	public string Name;
	public string Geometry;
	public TArray<FDMXImportGDTFDMXChannel> DMXChannels;
	public TArray<FDMXImportGDTFRelation> Relations;
	public TArray<FDMXImportGDTFFTMacro> FTMacros;
}
