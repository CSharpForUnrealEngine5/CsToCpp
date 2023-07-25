#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DMXPixelMappingScreenComponent.h")]
///<summary>DMX Screen(Grid) rendering component</summary>
public partial class UDMXPixelMappingScreenComponent : UDMXPixelMappingOutputDMXComponent {
// DMXPixelMappingScreenComponent
	public bool bSendToAllOutputPorts;
	public TArray<FDMXOutputPortReference> OutputPortReferences;
	public int NumXCells;
	public int NumYCells;
	public FDMXProtocolName ProtocolName_DEPRECATED;
	public int LocalUniverse;
	public int StartAddress;
	public EDMXCellFormat PixelFormat;
	public EDMXPixelMappingDistribution Distribution;
	public bool bIgnoreAlphaChannel;
	public float PixelIntensity;
	public float AlphaIntensity;
	public bool bShowAddresses;
	public bool bShowUniverse;
}
