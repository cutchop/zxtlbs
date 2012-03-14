using System;
using System.Collections.Generic;
using System.Text;

namespace Zxtlbs.Model
{
    [Serializable]
    public class BaseModel
    {
        public BaseModel()
        {
        }
        private int _pagesize = 10;
        private int _pagenum = 1;
        private int _pagestart = 0;
        private int _pageend = 10;

        public int PageSize
        {
            set { _pagesize = value; }
            get { return _pagesize; }
        }

        public int PageNum
        {
            set { _pagenum = value; }
            get { return _pagenum; }
        }

        public int PageStart
        {
            set { _pagestart = value; }
            get { return _pagestart; }
        }

        public int PageEnd
        {
            set { _pageend = value; }
            get { return _pageend; }
        }
    }
}
