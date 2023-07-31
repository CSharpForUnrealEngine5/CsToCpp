#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyValue.h")]
public partial class UPropertyValue : UObject {
	///<summary>GetPropertyTooltip</summary>
	public  string GetPropertyTooltip() { return default; }
	///<summary>GetFullDisplayString</summary>
	public  string GetFullDisplayString() { return default; }
	///<summary>HasRecordedData</summary>
	public  bool HasRecordedData() { return default; }
	///<summary>Properties were previously stored like this. Use CapturedPropSegments from now on, which stores</summary>
	public TArray<object> Properties_DEPRECATED;
	///<summary>PropertyIndices_DEPRECATED</summary>
	public TArray<int> PropertyIndices_DEPRECATED;
	///<summary>CapturedPropSegments</summary>
	public TArray<FCapturedPropSegment> CapturedPropSegments;
	///<summary>FullDisplayString</summary>
	public string FullDisplayString;
	///<summary>PropertySetterName</summary>
	public string PropertySetterName;
	///<summary>PropertySetterParameterDefaults</summary>
	public TMap<string,string> PropertySetterParameterDefaults;
	///<summary>bHasRecordedData</summary>
	public bool bHasRecordedData;
	///<summary>We use these mainly to know how to serialize/deserialize the values of properties that need special care</summary>
	public UClass LeafPropertyClass_DEPRECATED;
	///<summary>ValueBytes</summary>
	public TArray<byte> ValueBytes;
	///<summary>PropCategory</summary>
	public EPropertyValueCategory PropCategory;
	///<summary>DisplayOrder</summary>
	public uint DisplayOrder;
}
