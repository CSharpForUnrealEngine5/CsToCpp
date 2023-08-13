namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeMaterialFactoryNode.h")]
public partial class UInterchangeMaterialFunctionFactoryNode : UInterchangeBaseMaterialFactoryNode {
	public static UClass StaticClass() {return default;}
	///<summary>GetObjectClass</summary>
	public virtual UClass GetObjectClass() { return default; }
	///<summary>GetInputConnection</summary>
	public bool GetInputConnection(string InputName,string ExpressionNodeUid,string OutputName) { return default; }
}
