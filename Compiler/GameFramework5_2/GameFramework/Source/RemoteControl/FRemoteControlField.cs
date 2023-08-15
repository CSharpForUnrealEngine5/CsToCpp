namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a property or function that has been exposed to remote control.</summary>
[CppInclude("RemoteControlField.h")]
public partial struct FRemoteControlField {
	public EExposedFieldType FieldType;
	public FName FieldName;
	public FRCFieldPathInfo FieldPathInfo;
	public TArray<string> ComponentHierarchy_DEPRECATED;
	public TSet<FRemoteControlProtocolBinding> ProtocolBindings;
	public FSoftClassPath OwnerClass;
	public bool bIsEditorOnly;
	public byte ActiveMasks;
}
