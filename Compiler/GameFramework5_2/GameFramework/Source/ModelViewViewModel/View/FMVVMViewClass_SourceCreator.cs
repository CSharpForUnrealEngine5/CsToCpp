#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("View/MVVMViewClass.h")]
///<summary>Shared data to find or create a ViewModel at runtime.</summary>
public partial struct FMVVMViewClass_SourceCreator {
// MVVMViewClass_SourceCreator
	public UClass ExpectedSourceType;
	public FMVVMViewModelContext GlobalViewModelInstance;
	public FMVVMVCompiledFieldPath FieldPath;
	public string PropertyName;
	public bool bCreateInstance;
	public bool bOptional;
}
