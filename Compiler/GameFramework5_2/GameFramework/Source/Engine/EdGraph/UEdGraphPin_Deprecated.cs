#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraphPin.h")]
public partial class UEdGraphPin_Deprecated : UObject {
// EdGraphPin_Deprecated
	public string PinName;
	public string PinFriendlyName;
	public string PinToolTip;
	public EEdGraphPinDirection Direction;
	public FEdGraphPinType PinType;
	public string DefaultValue;
	public string AutogeneratedDefaultValue;
	public UObject DefaultObject;
	public string DefaultTextValue;
	public TArray<UEdGraphPin_Deprecated> LinkedTo;
	public TArray<UEdGraphPin_Deprecated> SubPins;
	public UEdGraphPin_Deprecated ParentPin;
	public UEdGraphPin_Deprecated ReferencePassThroughConnection;
	public bool bHidden;
	public bool bNotConnectable;
	public bool bDefaultValueIsReadOnly;
	public bool bDefaultValueIsIgnored;
	public bool bAdvancedView;
	public bool bDisplayAsMutableRef;
	public FGuid PersistentGuid;
}
