namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Pin represents a single connector / pin on a node in the RigVM model.</summary>
[CppInclude("RigVMModel/RigVMPin.h")]
public partial class URigVMPin : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Returns a . separated path containing all names of the pin and its owners,</summary>
	public string GetPinPath(bool bUseNodePath/*=false*/) { return default; }
	///<summary>Returns a . separated path containing all names of the pin and its owners</summary>
	public string GetSubPinPath(URigVMPin InParentPin,bool bIncludeParentPinName/*=false*/) { return default; }
	///<summary>Returns a . separated path containing all names of the pin within its main</summary>
	public string GetSegmentPath(bool bIncludeRootPin/*=false*/) { return default; }
	///<summary>Returns the display label of the pin</summary>
	public FName GetDisplayName() { return default; }
	///<summary>Returns the direction of the pin</summary>
	public ERigVMPinDirection GetDirection() { return default; }
	///<summary>Returns true if the pin is currently expanded</summary>
	public bool IsExpanded() { return default; }
	///<summary>Returns true if the pin is defined as a constant value / literal</summary>
	public bool IsDefinedAsConstant() { return default; }
	///<summary>Returns true if the pin should be watched</summary>
	public bool RequiresWatch(bool bCheckExposedPinChain/*=false*/) { return default; }
	///<summary>Returns true if the data type of the Pin is a enum</summary>
	public bool IsEnum() { return default; }
	///<summary>Returns true if the data type of the Pin is a struct</summary>
	public bool IsStruct() { return default; }
	///<summary>Returns true if the Pin is a SubPin within a struct</summary>
	public bool IsStructMember() { return default; }
	///<summary>Returns true if the data type of the Pin is a uobject</summary>
	public bool IsUObject() { return default; }
	///<summary>Returns true if the data type of the Pin is a interface</summary>
	public bool IsInterface() { return default; }
	///<summary>Returns true if the data type of the Pin is an array</summary>
	public bool IsArray() { return default; }
	///<summary>Returns true if the Pin is a SubPin within an array</summary>
	public bool IsArrayElement() { return default; }
	///<summary>Returns true if this pin represents a dynamic array</summary>
	public bool IsDynamicArray() { return default; }
	///<summary>Returns true if this data type is referenced counted</summary>
	public bool IsReferenceCountedContainer() { return default; }
	///<summary>Returns true if this pin&#39;s value may be executed lazily</summary>
	public bool IsLazy() { return default; }
	///<summary>Returns the index of the Pin within the node / parent Pin</summary>
	public int GetPinIndex() { return default; }
	///<summary>Returns the absolute index of the Pin within the node / parent Pin</summary>
	public int GetAbsolutePinIndex() { return default; }
	///<summary>Returns the number of elements within an array Pin</summary>
	public int GetArraySize() { return default; }
	///<summary>Returns the C++ data type of the pin</summary>
	public string GetCPPType() { return default; }
	///<summary>Returns the C++ data type of an element of the Pin array</summary>
	public string GetArrayElementCppType() { return default; }
	///<summary>Returns true if the C++ data type is FString or FName</summary>
	public bool IsStringType() { return default; }
	///<summary>Returns true if the C++ data type is an execute context</summary>
	public bool IsExecuteContext() { return default; }
	///<summary>Returns true if the C++ data type is unknown</summary>
	public bool IsWildCard() { return default; }
	///<summary>Returns true if any of the subpins is a wildcard</summary>
	public bool ContainsWildCardSubPin() { return default; }
	///<summary>Returns true if this pin is an array that should be displayed as elements only</summary>
	public bool IsFixedSizeArray() { return default; }
	///<summary>Returns the default value of the Pin as a string.</summary>
	public string GetDefaultValue() { return default; }
	///<summary>Returns the name of a custom widget to be used</summary>
	public FName GetCustomWidgetName() { return default; }
	///<summary>Returns the tooltip of this pin</summary>
	public FText GetToolTipText() { return default; }
	///<summary>Returns the struct of the data type of the Pin,</summary>
	public UObject GetCPPTypeObject() { return default; }
	///<summary>Returns the struct of the data type of the Pin,</summary>
	public UScriptStruct GetScriptStruct() { return default; }
	///<summary>Returns the enum of the data type of the Pin,</summary>
	public UEnum GetEnum() { return default; }
	///<summary>Returns the parent Pin - or nullptr if the Pin</summary>
	public URigVMPin GetParentPin() { return default; }
	///<summary>Returns the top-most parent Pin, so for example</summary>
	public URigVMPin GetRootPin() { return default; }
	///<summary>Returns true if this pin is a root pin</summary>
	public bool IsRootPin() { return default; }
	///<summary>Returns the pin to be used for a link.</summary>
	public URigVMPin GetPinForLink() { return default; }
	///<summary>Returns the link that represents the connection</summary>
	public URigVMLink FindLinkForPin(URigVMPin InOtherPin) { return default; }
	///<summary>Returns the original pin for a pin on an injected</summary>
	public URigVMPin GetOriginalPinFromInjectedNode() { return default; }
	///<summary>Returns all of the SubPins of this one.</summary>
	public TArray<URigVMPin> GetSubPins() { return default; }
	///<summary>Returns a SubPin given a name / path or nullptr.</summary>
	public URigVMPin FindSubPin(string InPinPath) { return default; }
	///<summary>Returns true if this Pin is linked to another Pin</summary>
	public bool IsLinkedTo(URigVMPin InPin) { return default; }
	///<summary>Returns all of the links linked to this Pin.</summary>
	public TArray<URigVMLink> GetLinks() { return default; }
	///<summary>Returns all of the linked source Pins,</summary>
	public TArray<URigVMPin> GetLinkedSourcePins(bool bRecursive/*=false*/) { return default; }
	///<summary>Returns all of the linked target Pins,</summary>
	public TArray<URigVMPin> GetLinkedTargetPins(bool bRecursive/*=false*/) { return default; }
	///<summary>Returns all of the source pins</summary>
	public TArray<URigVMLink> GetSourceLinks(bool bRecursive/*=false*/) { return default; }
	///<summary>Returns all of the target links,</summary>
	public TArray<URigVMLink> GetTargetLinks(bool bRecursive/*=false*/) { return default; }
	///<summary>Returns the node of this Pin.</summary>
	public URigVMNode GetNode() { return default; }
	///<summary>Returns the graph of this Pin.</summary>
	public URigVMGraph GetGraph() { return default; }
	///<summary>DisplayName</summary>
	public FName DisplayName;
	///<summary>if new members are added to the pin in the future</summary>
	public ERigVMPinDirection Direction;
	///<summary>bIsExpanded</summary>
	public bool bIsExpanded;
	///<summary>bIsConstant</summary>
	public bool bIsConstant;
	///<summary>bRequiresWatch</summary>
	public bool bRequiresWatch;
	///<summary>bIsDynamicArray</summary>
	public bool bIsDynamicArray;
	///<summary>CPPType</summary>
	public string CPPType;
	///<summary>serialize object ptr here to keep track of the latest version of the type object,</summary>
	public UObject CPPTypeObject;
	///<summary>CPPTypeObjectPath</summary>
	public FName CPPTypeObjectPath;
	///<summary>DefaultValue</summary>
	public string DefaultValue;
	///<summary>CustomWidgetName</summary>
	public FName CustomWidgetName;
	///<summary>SubPins</summary>
	public TArray<URigVMPin> SubPins;
	///<summary>Links</summary>
	public TArray<URigVMLink> Links;
	///<summary>InjectionInfos</summary>
	public TArray<URigVMInjectionInfo> InjectionInfos;
	///<summary>BoundVariablePath_DEPRECATED</summary>
	public string BoundVariablePath_DEPRECATED;
}
