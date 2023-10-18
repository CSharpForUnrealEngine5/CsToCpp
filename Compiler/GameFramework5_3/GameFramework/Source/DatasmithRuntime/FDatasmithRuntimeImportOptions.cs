namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithRuntime.h")]
public partial struct FDatasmithRuntimeImportOptions {
	public FDatasmithTessellationOptions TessellationOptions;
	public EBuildHierarchyMethod BuildHierarchy;
	public ECollisionEnabled BuildCollisions;
	public ECollisionTraceFlag CollisionType;
	public bool bImportMetaData;
}
