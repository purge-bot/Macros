using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public class Memory
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int ReadProcessMemory(
            IntPtr hProcess,
            int lpBaseAddress,
            byte[] lpBuffer,
            int nSize,
            out IntPtr NumberofBytesRead
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            byte[] lpBuffer,
            Int32 nSize,
            out IntPtr lpNumberOfBytesWritten);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, IntPtr lParam);

        private const int // Команды для SendMessage
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205,
            WM_LBUTTONDOWN = 513,
            WM_LBUTTONUP = 514;

        private IntPtr _handleWithAccess;
        private IntPtr _clientWindow;

        public Memory(ClientWindow client)
        {
            _handleWithAccess = client.handleWithAccess;
            _clientWindow = client.clientWindow;
        }

        public byte[] ReadAddress(int addr, int size)
        {
            byte[] buffer = new byte[size];
            ReadProcessMemory(_handleWithAccess, addr, buffer, size, out _);
            return buffer;
        }

        public void WriteAddress(int addr, int newValue, int size)
        {
            byte[] buffer = BitConverter.GetBytes(newValue);
            WriteProcessMemory(_handleWithAccess, (IntPtr)addr, buffer, size, out _);
        }

        public void ClickLB(int x, int y)
        {
            SendMessage(_clientWindow, WM_LBUTTONDOWN, 0, new IntPtr(y * 0x10000 + x));
            SendMessage(_clientWindow, WM_LBUTTONUP, 0, new IntPtr(y * 0x10000 + x));
        }

        public void ClickRB(int x, int y)
        {
            SendMessage(_clientWindow, WM_RBUTTONDOWN, 0, new IntPtr(y * 0x10000 + x));
            SendMessage(_clientWindow, WM_RBUTTONUP, 0, new IntPtr(y * 0x10000 + x));
        }
    }
}
