#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialParameterCollection.h")]
///<summary>Asset class that contains a list of parameter names and their default values.</summary>
public partial class UMaterialParameterCollection : UObject {
// MaterialParameterCollection
	public FGuid StateId;
	public TArray<FCollectionScalarParameter> ScalarParameters;
	public TArray<FCollectionVectorParameter> VectorParameters;
	public TArray<string> GetScalarParameterNames() { return default; }
	public TArray<string> GetVectorParameterNames() { return default; }
	public float GetScalarParameterDefaultValue(string ParameterName,bool bParameterFound) { return default; }
	public FLinearColor GetVectorParameterDefaultValue(string ParameterName,bool bParameterFound) { return default; }
}
