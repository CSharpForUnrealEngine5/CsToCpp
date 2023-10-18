namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base struct for collection parameters</summary>
[CppInclude("Materials/MaterialParameterCollection.h")]
public partial struct FCollectionParameterBase {
	public FName ParameterName;
	public FGuid Id;
}
