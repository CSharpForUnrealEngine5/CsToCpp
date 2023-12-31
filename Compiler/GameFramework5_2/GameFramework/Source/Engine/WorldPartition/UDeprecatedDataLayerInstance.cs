namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class used for Runtime Conversion of the Deprecated UDataLayer Class to UDataLayerInstance + UDataLayerAsset.</summary>
[CppInclude("WorldPartition/DataLayer/DeprecatedDataLayerInstance.h")]
public partial class UDeprecatedDataLayerInstance : UDataLayerInstance {
	public static UClass StaticClass() {return default;}
	///<summary>Label</summary>
	public FName Label;
	///<summary>DeprecatedDataLayerFName</summary>
	public FName DeprecatedDataLayerFName;
	///<summary>DataLayerType</summary>
	public EDataLayerType DataLayerType;
	///<summary>DebugColor</summary>
	public FColor DebugColor;
}
