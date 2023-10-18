namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Point filter on range that allows to do &quot;A op B&quot; type filtering, where A is the input spatial data,</summary>
[CppInclude("Elements/PCGPointFilter.h")]
public partial class UPCGPointFilterRangeSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Target property/attribute related properties</summary>
	public FPCGAttributePropertyInputSelector TargetAttribute;
	///<summary>Threshold property/attribute/constant related properties</summary>
	public FPCGPointFilterThresholdSettings MinThreshold;
	///<summary>MaxThreshold</summary>
	public FPCGPointFilterThresholdSettings MaxThreshold;
}
