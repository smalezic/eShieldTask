using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerator
{
    public class FileAttribute
    {
        #region Fields & Properties

        private readonly FileAttributes _attribute;
        public FileAttributes Attribute
        {
            get { return _attribute; }
        }

        private readonly DateTime _crationTime;
        public DateTime CreationTime
        {
            get { return _crationTime; }
        }

        private readonly DateTime _lastAccessTime;
        public DateTime LastAccessTime
        {
            get { return _lastAccessTime; }
        }

        private readonly DateTime _lastWriteTime;
        public DateTime LastWriteTime
        {
            get { return _lastWriteTime; }
        }

        private readonly uint _fileSizeHigh;
        public uint FileSizeHigh
        {
            get { return _fileSizeHigh; }
        }

        private readonly uint _fileSizeLow;
        public uint FileSizeLow
        {
            get { return _fileSizeLow; }
        }

        public readonly bool _result;
        public bool Result
        {
            get { return _result; }
        }

        #endregion Fields & Properties

        #region Constructor

        public FileAttribute(
            bool result,
            FileAttributes attribute,
            DateTime crationTime,
            DateTime lastAccessTime,
            DateTime lastWriteTime,
            uint fileSizeHigh,
            uint fileSizeLow)
        {
            this._result = result;
            this._attribute = attribute;
            this._crationTime = crationTime;
            this._lastAccessTime = lastAccessTime;
            this._lastWriteTime = lastWriteTime;
            this._fileSizeHigh = fileSizeHigh;
            this._fileSizeLow = fileSizeLow;
        }

        #endregion Constructor
    }
}