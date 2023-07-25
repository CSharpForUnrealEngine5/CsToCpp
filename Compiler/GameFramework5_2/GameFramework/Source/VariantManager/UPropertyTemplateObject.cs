#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyTemplateObject.h")]
///<summary>In order to use PropertyEditorModule.CreateSingleProperty we have to give it an object instance</summary>
public partial class UPropertyTemplateObject : UObject {
// PropertyTemplateObject
	public byte CapturedByteProperty;
	public ushort CapturedUInt16Property;
	public uint CapturedUInt32Property;
	public ulong CapturedUInt64Property;
	public short CapturedInt8Property;
	public short CapturedInt16Property;
	public int CapturedIntProperty;
	public long CapturedInt64Property;
	public float CapturedFloatProperty;
	public double CapturedDoubleProperty;
	public bool bCapturedBoolProperty;
	public UObject CapturedObjectProperty;
	public TSoftObjectPtr<UObject> CapturedSoftObjectProperty;
	public object /*CapturedInterfaceProperty*/ CapturedInterfaceProperty;
	public string CapturedNameProperty;
	public string CapturedStrProperty;
	public string CapturedTextProperty;
	public FVector CapturedVectorProperty;
}
