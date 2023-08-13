namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset class that contains a list of parameter names and their default values.</summary>
[CppInclude("Materials/MaterialParameterCollection.h")]
public partial class UMaterialParameterCollection : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Used by materials using this collection to know when to recompile.</summary>
	public FGuid StateId;
	///<summary>ScalarParameters</summary>
	public TArray<FCollectionScalarParameter> ScalarParameters;
	///<summary>VectorParameters</summary>
	public TArray<FCollectionVectorParameter> VectorParameters;
	///<summary>Returns an array of the names of all the scalar parameters in this Material Parameter Collection *</summary>
	public TArray<string> GetScalarParameterNames() { return default; }
	///<summary>Returns an array of the names of all the vector parameters in this Material Parameter Collection *</summary>
	public TArray<string> GetVectorParameterNames() { return default; }
	///<summary>Gets the default value of a scalar parameter from a material collection.</summary>
	public float GetScalarParameterDefaultValue(string ParameterName,bool bParameterFound) { return default; }
	///<summary>Gets the default value of a scalar parameter from a material collection.</summary>
	public FLinearColor GetVectorParameterDefaultValue(string ParameterName,bool bParameterFound) { return default; }
}
