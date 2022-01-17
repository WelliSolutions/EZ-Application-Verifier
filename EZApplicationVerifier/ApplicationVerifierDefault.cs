using Microsoft.Win32;

namespace ThomasWeller.EasyAppVerif
{
    class ApplicationVerifierDefault
    {
        private readonly string _exeName;

        internal ApplicationVerifierDefault(string exeName)
        {
            _exeName = exeName;
        }

        internal void Enable()
        {
            RegistryKey key;
            key = Registry.LocalMachine.CreateSubKey(Subkey);
            key?.SetValue("VerifierDlls", "vrfcore.dll vfbasics.dll");
            key?.SetValue("GlobalFlag", "0x100");
            key?.SetValue("VerifierFlags", unchecked((int)0x81643027), RegistryValueKind.DWord);
            key?.SetValue("PageHeapFlags", "0x3");
            key?.SetValue("DelayFreeSizeMB", 0x00000040, RegistryValueKind.DWord);
            key = Registry.LocalMachine.CreateSubKey($"{Subkey}\\Core-{{E5DCDFAA-3B35-46A8-B370-9D3575A68E53}}");
            key?.SetValue("Propagate", 0x00000000, RegistryValueKind.DWord);
            key?.SetValue("AutoClr", 0x00000000, RegistryValueKind.DWord);
            key?.SetValue("AutoDisableStop", 0x00000001, RegistryValueKind.DWord);
            key?.SetValue("LoggingWithLocksHeld", 0x00000001, RegistryValueKind.DWord);
            key?.SetValue("ExceptionOnStop", 0x00000000, RegistryValueKind.DWord);
            key?.SetValue("MinimumMemoryOverhead", 0x00000000, RegistryValueKind.DWord);
            Registry.LocalMachine.CreateSubKey($"{Subkey}\\Exceptions-{{F86B022F-E589-4e8f-B0DD-6B7AF9D71A59}}");
            key = Registry.LocalMachine.CreateSubKey($"{Subkey}\\Handles-{{9760941A-8DA5-4dbe-843B-0EBD376CAB02}}");
            key?.SetValue("Traces", 0x00001000, RegistryValueKind.DWord);
            Registry.LocalMachine.CreateSubKey($"{Subkey}\\Heaps-{{4D056CEB-D8E3-4b85-B148-B543D56D9BDE}}");
            key = Registry.LocalMachine.CreateSubKey($"{Subkey}\\Leak-{{81EEC8DA-0E61-4942-8037-9A6C4A86510D}}");
            key?.SetValue("ExcludeDlls", "");
            key?.SetValue("ExcludeUCRT", 0x00000000, RegistryValueKind.DWord);
            Registry.LocalMachine.CreateSubKey($"{Subkey}\\Locks-{{159D60EC-F459-456b-A27B-1076AD59F8F4}}");
            key = Registry.LocalMachine.CreateSubKey($"{Subkey}\\Memory-{{8A70B8A4-4FA6-41c3-85EE-595FCB3E1051}}");
            key?.SetValue("ExecWritePage", 0x00000000, RegistryValueKind.DWord);
            Registry.LocalMachine.CreateSubKey($"{Subkey}\\SRWLock-{{6335D1CF-7955-414e-8C6A-1A40AC9357AC}}");
            key = Registry.LocalMachine.CreateSubKey($"{Subkey}\\Threadpool-{{F15FC24E-53A0-444D-8D28-F7697EDD9C83}}");
            key?.SetValue("AsyncCheck", 0x00000000, RegistryValueKind.DWord);
            Registry.LocalMachine.CreateSubKey($"{Subkey}\\TLS-{{EDDA96DB-D216-467d-BE3C-8603745EDA43}}");
        }

        public void Disable()
        {
            Registry.LocalMachine.DeleteSubKeyTree(Subkey, false);
        }

        private string Subkey
        {
            get
            {
                var ifeo = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\";
                var subkey = $"{ifeo}{_exeName}";
                return subkey;
            }
        }
    }
}
