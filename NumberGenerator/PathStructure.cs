using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerator
{
    internal class PathStructure
    {
        private readonly String _path;
        private readonly int _lastIndexOfBackslash;

        internal PathStructure(String path)
        {
            this._path = path;
            this._lastIndexOfBackslash = path.LastIndexOf('\\');
        }

        public String GetFileName()
        {
            String retVal;

            try
            {
                if (_lastIndexOfBackslash > -1)
                {
                    if (_lastIndexOfBackslash + 1 < _path.Length)
                    {
                        retVal = _path.Substring(_lastIndexOfBackslash + 1);
                    }
                    else
                    {
                        retVal = String.Empty;
                    }
                }
                else
                {
                    retVal = _path;
                }
            }
            catch (Exception)
            {
                retVal = null;
            }

            return retVal;
        }
        
        public String GetFolderName()
        {
            String retVal;

            try
            {
                if (_lastIndexOfBackslash > -1)
                {
                    retVal = _path.Substring(0, _lastIndexOfBackslash + 1);
                }
                else
                {
                    retVal = String.Empty;
                }
            }
            catch (Exception)
            {
                retVal = null;
            }

            return retVal;
        }
    }
}
