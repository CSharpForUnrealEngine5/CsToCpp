#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXImportGDTF.h")]
public partial class UDMXImportGDTFPhysicalDescriptions : UDMXImportPhysicalDescriptions {
	public static UClass StaticClass() {return default;}
	///<summary>Emitters</summary>
	public TArray<FDMXImportGDTFEmitter> Emitters;
	///<summary>ColorSpace</summary>
	public FDMXImportGDTFColorSpace ColorSpace;
	///<summary>DMXProfiles</summary>
	public FDMXImportGDTFDMXProfiles DMXProfiles;
	///<summary>CRIs</summary>
	public FDMXImportGDTFCRIs CRIs;
}
