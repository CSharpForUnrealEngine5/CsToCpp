#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>DMX Screen(Grid) rendering component</summary>
[CppInclude("Components/DMXPixelMappingScreenComponent.h")]
public partial class UDMXPixelMappingScreenComponent : UDMXPixelMappingOutputDMXComponent {
	public static UClass StaticClass() {return default;}
	///<summary>If true, outputs to all DMX Output Ports</summary>
	public bool bSendToAllOutputPorts;
	///<summary>The port this render component outputs to</summary>
	public TArray<FDMXOutputPortReference> OutputPortReferences;
	///<summary>NumXCells</summary>
	public int NumXCells;
	///<summary>NumYCells</summary>
	public int NumYCells;
	///<summary>ProtocolName_DEPRECATED</summary>
	public FDMXProtocolName ProtocolName_DEPRECATED;
	///<summary>LocalUniverse</summary>
	public int LocalUniverse;
	///<summary>StartAddress</summary>
	public int StartAddress;
	///<summary>PixelFormat</summary>
	public EDMXCellFormat PixelFormat;
	///<summary>Distribution</summary>
	public EDMXPixelMappingDistribution Distribution;
	///<summary>bIgnoreAlphaChannel</summary>
	public bool bIgnoreAlphaChannel;
	///<summary>PixelIntensity</summary>
	public float PixelIntensity;
	///<summary>AlphaIntensity</summary>
	public float AlphaIntensity;
	///<summary>bShowAddresses</summary>
	public bool bShowAddresses;
	///<summary>bShowUniverse</summary>
	public bool bShowUniverse;
}
