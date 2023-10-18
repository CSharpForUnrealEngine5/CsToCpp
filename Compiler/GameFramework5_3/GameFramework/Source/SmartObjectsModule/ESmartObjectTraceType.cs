namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectTypes.h")]
///<summary>Indicates how TagQueries from slots and parent object will be processed against Tags from a find request.</summary>
public enum ESmartObjectTraceType {
	ByChannel=0,
	ByProfile=1,
	ByObjectTypes=2,
}
