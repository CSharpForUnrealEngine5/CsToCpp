using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("GameFramework/Controller.h")]
    public partial class AController : AActor {
        public FRotator GetControlRotation(){ return default(FRotator); }
        public APawn GetPawn() { return null; }
}

}