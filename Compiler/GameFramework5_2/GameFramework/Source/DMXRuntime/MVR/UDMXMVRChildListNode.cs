namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This node defines a generic graphical object.</summary>
[CppInclude("MVR/Types/DMXMVRChildListNode.h")]
public partial class UDMXMVRChildListNode : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>A list of geometrical representation objects that are part of the object.</summary>
	public TArray<UDMXMVRParametricObjectNodeBase> ParametricObjectNodes;
}
