#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyValue.h")]
public partial class UPropertyValue : UObject {
// PropertyValue
	public string GetPropertyTooltip() { return default; }
	public string GetFullDisplayString() { return default; }
	public bool HasRecordedData() { return default; }
	public TArray<object> Properties_DEPRECATED;
	public TArray<int> PropertyIndices_DEPRECATED;
	public TArray<FCapturedPropSegment> CapturedPropSegments;
	public string FullDisplayString;
	public string PropertySetterName;
	public TMap<string,string> PropertySetterParameterDefaults;
	public bool bHasRecordedData;
	public UClass LeafPropertyClass_DEPRECATED;
	public TArray<byte> ValueBytes;
	public EPropertyValueCategory PropCategory;
	public uint DisplayOrder;
}
