namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXImportGDTF.h")]
public partial class UDMXImportGDTFDMXModes : UDMXImportDMXModes {
	public static UClass StaticClass() {return default;}
	///<summary>DMXModes</summary>
	public TArray<FDMXImportGDTFDMXMode> DMXModes;
	///<summary>GetDMXChannelFunctions</summary>
	public TArray<FDMXImportGDTFChannelFunction> GetDMXChannelFunctions(FDMXImportGDTFDMXMode InMode) { return default; }
}
