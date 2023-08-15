namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXImportGDTF.h")]
public partial struct FDMXImportGDTFDMXMode {
	public FName Name;
	public FName Geometry;
	public TArray<FDMXImportGDTFDMXChannel> DMXChannels;
	public TArray<FDMXImportGDTFRelation> Relations;
	public TArray<FDMXImportGDTFFTMacro> FTMacros;
}
