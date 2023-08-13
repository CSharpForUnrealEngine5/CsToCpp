namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolContextInterfaces.h")]
///<summary>Type of change we want to apply to a selection</summary>
public enum ESelectedObjectsModificationType {
	Replace=0,
	Add=1,
	Remove=2,
	Clear=3,
}
