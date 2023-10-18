namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to configure which NetDriver is started with Iris enabled or not</summary>
[CppInclude("Engine/Engine.h")]
public partial struct FIrisNetDriverConfig {
	public FName NetDriverDefinition;
	public FName NetDriverName;
	public string NetDriverWildcardName;
	public bool bCanUseIris;
}
