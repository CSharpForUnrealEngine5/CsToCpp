#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class used for Runtime Conversion of the Deprecated UDataLayer Class to UDataLayerInstance + UDataLayerAsset.</summary>
[CppInclude("WorldPartition/DataLayer/DeprecatedDataLayerInstance.h")]
public partial class UDeprecatedDataLayerInstance : UDataLayerInstance {
	///<summary>Label</summary>
	public string Label;
	///<summary>DeprecatedDataLayerFName</summary>
	public string DeprecatedDataLayerFName;
	///<summary>DataLayerType</summary>
	public EDataLayerType DataLayerType;
	///<summary>DebugColor</summary>
	public FColor DebugColor;
}
