namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCompiler/RigVMCompiler.h")]
public partial struct FRigVMCompileSettings {
	public bool SurpressInfoMessages;
	public bool SurpressWarnings;
	public bool SurpressErrors;
	public bool EnablePinWatches;
	public bool IsPreprocessorPhase;
	public FRigVMParserASTSettings ASTSettings;
	public bool SetupNodeInstructionIndex;
}
