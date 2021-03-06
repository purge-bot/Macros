using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Eos_Macros
{
    public class ClientWindow
    {

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        [DllImport("kernel32", SetLastError = true)]
        public static extern IntPtr OpenProcess(
            int dwDesiredAccess,
            IntPtr bInheritHandle,
            int dwProcessId
            );

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public delegate bool EnumWindowsProc(IntPtr hwnd, IntPtr lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumChildWindows(IntPtr hwndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);

        const int PROCESS_ALL_ACCESS = 0X1F0FFF;

        public Memory Command { get; set; }

        public bool CharacterIsFound { get; set; }

        public IntPtr clientWindow;
        public IntPtr clientProcess;
        public IntPtr handleWithAccess;

        public ClientWindow()
        {
            FindWindow();
            Command = new Memory(this);
        }

        public void FindWindow()
        {         
            int procId;

            Process[] process = Process.GetProcesses();
            foreach (Process pro in process)
            {

                if (pro.ProcessName == "MUDClient")
                {
                    clientProcess = pro.MainWindowHandle;
                    CharacterIsFound = true;
                    break;
                }
            }
            clientWindow = FindWindow("TForm1", "SW");

            if(clientWindow.ToInt32() == 0)
            {
                CharacterIsFound = false;
                return;
            }

            GetWindowThreadProcessId(clientWindow, out procId);
            handleWithAccess = OpenProcess(PROCESS_ALL_ACCESS, IntPtr.Zero, procId);
            // EnumChildWindows(clientProcess, ClientProcess, IntPtr.Zero);
            CharacterIsFound = true;
        }
    }
}
