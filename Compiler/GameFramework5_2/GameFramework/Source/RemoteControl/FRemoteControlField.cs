#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlField.h")]
///<summary>Represents a property or function that has been exposed to remote control.</summary>
public partial struct FRemoteControlField {
// RemoteControlField
	public EExposedFieldType FieldType;
	public string FieldName;
	public FRCFieldPathInfo FieldPathInfo;
	public TArray<string> ComponentHierarchy_DEPRECATED;
	public TSet<FRemoteControlProtocolBinding> ProtocolBindings;
	public FSoftClassPath OwnerClass;
	public bool bIsEditorOnly;
	public byte ActiveMasks;
}
