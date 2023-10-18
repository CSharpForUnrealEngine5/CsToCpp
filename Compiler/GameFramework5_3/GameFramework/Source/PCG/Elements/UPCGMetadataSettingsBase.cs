namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all Metadata operations.</summary>
[CppInclude("Elements/Metadata/PCGMetadataOpElementBase.h")]
public partial class UPCGMetadataSettingsBase : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>OutputTarget</summary>
	public FPCGAttributePropertyOutputSelector OutputTarget;
	///<summary>By default, output is taken from first non-param pin (aka if the second pin is a point data, the output will be this point data). You can change it to any available input pin.</summary>
	public FName OutputDataFromPin;
	///<summary>OutputAttributeName_DEPRECATED</summary>
	public FName OutputAttributeName_DEPRECATED;
	///<summary>Mode_DEPRECATED</summary>
	public EPCGMetadataSettingsBaseMode Mode_DEPRECATED;
	///<summary>Return the list of all the Input pins</summary>
	public TArray<FName> GetOutputDataFromPinOptions() { return default; }
}
