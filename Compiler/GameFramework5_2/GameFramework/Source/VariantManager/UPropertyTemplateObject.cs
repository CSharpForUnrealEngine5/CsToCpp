#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>In order to use PropertyEditorModule.CreateSingleProperty we have to give it an object instance</summary>
[CppInclude("PropertyTemplateObject.h")]
public partial class UPropertyTemplateObject : UObject {
	///<summary>Captured byte property</summary>
	public byte CapturedByteProperty;
	///<summary>Captured uint16 property</summary>
	public ushort CapturedUInt16Property;
	///<summary>Captured uint32 property</summary>
	public uint CapturedUInt32Property;
	///<summary>Captured uint16 property</summary>
	public ulong CapturedUInt64Property;
	///<summary>Captured int8 property</summary>
	public short CapturedInt8Property;
	///<summary>Captured int16 property</summary>
	public short CapturedInt16Property;
	///<summary>Captured int32 property</summary>
	public int CapturedIntProperty;
	///<summary>Captured int64 property</summary>
	public long CapturedInt64Property;
	///<summary>Captured float property</summary>
	public float CapturedFloatProperty;
	///<summary>Captured double property</summary>
	public double CapturedDoubleProperty;
	///<summary>Captured boolean property</summary>
	public bool bCapturedBoolProperty;
	///<summary>Captured UObject property</summary>
	public UObject CapturedObjectProperty;
	///<summary>Captured Soft UObject property</summary>
	public TSoftObjectPtr<UObject> CapturedSoftObjectProperty;
	///<summary>Captured UInterface property</summary>
	public object /*CapturedInterfaceProperty*/ CapturedInterfaceProperty;
	///<summary>Captured FName property</summary>
	public string CapturedNameProperty;
	///<summary>Captured FString property</summary>
	public string CapturedStrProperty;
	///<summary>Captured FText property</summary>
	public string CapturedTextProperty;
	///<summary>Captured FVector property</summary>
	public FVector CapturedVectorProperty;
}
