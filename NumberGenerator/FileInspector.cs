using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;

namespace NumberGenerator
{
    public class FileInspector
    {
        #region Fields

        private readonly String _fileName;

        public String FileName
        {
            get { return _fileName; }
        }

        #endregion Fields

        #region Constructor

        public FileInspector(String fileName)
        {
            this._fileName = fileName;
        }

        #endregion Constructor

        #region Public Method

        public FileAttribute GetFileAttributes()
        {
            FileAttribute retVal = null;

            try
            {
                WIN32_FILE_ATTRIBUTE_DATA fileData = new WIN32_FILE_ATTRIBUTE_DATA();

                var result = GetFileAttributesEx(_fileName, GET_FILEEX_INFO_LEVELS.GetFileExInfoStandard, out fileData);
                var x = fileData.ftCreationTime;

                if (result)
                {
                    retVal = new FileAttribute(
                        result,
                        fileData.dwFileAttributes,
                        ConvertToDateTime(fileData.ftCreationTime),
                        ConvertToDateTime(fileData.ftLastAccessTime),
                        ConvertToDateTime(fileData.ftLastWriteTime),
                        fileData.nFileSizeHigh,
                        fileData.nFileSizeLow );
                }
            }
            catch
            {
                
            }

            return retVal;
        }

        #endregion Public Method

        #region Private Method

        private DateTime ConvertToDateTime(System.Runtime.InteropServices.ComTypes.FILETIME time)
        {
            ulong high = (ulong)time.dwHighDateTime;
            uint low = (uint)time.dwLowDateTime;
            long fileTime = (long)((high << 32) + low);

            try
            {
                return DateTime.FromFileTimeUtc(fileTime);
            }
            catch
            {
                return DateTime.FromFileTimeUtc(0xFFFFFFFF);
            }
        }

        #endregion Private Method

        #region Win32 API Method

        [StructLayout(LayoutKind.Sequential)]
        private struct WIN32_FILE_ATTRIBUTE_DATA
        {
            public FileAttributes dwFileAttributes;
            public System.Runtime.InteropServices.ComTypes.FILETIME ftCreationTime;
            public System.Runtime.InteropServices.ComTypes.FILETIME ftLastAccessTime;
            public System.Runtime.InteropServices.ComTypes.FILETIME ftLastWriteTime;
            public uint nFileSizeHigh;
            public uint nFileSizeLow;
        }

        private enum GET_FILEEX_INFO_LEVELS
        {
            GetFileExInfoStandard,
            GetFileExMaxInfoLevel
        }

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetFileAttributesEx(string lpFileName,
            GET_FILEEX_INFO_LEVELS fInfoLevelId, out WIN32_FILE_ATTRIBUTE_DATA fileData);

        #endregion Win32 API Method
    }
}
