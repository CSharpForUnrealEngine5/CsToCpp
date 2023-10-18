namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendInterfaceBinding {
	public FMetasoundFrontendVersion OutputInterfaceVersion;
	public FMetasoundFrontendVersion InputInterfaceVersion;
	public int BindingPriority;
	public TArray<FMetasoundFrontendInterfaceVertexBinding> VertexBindings;
}
