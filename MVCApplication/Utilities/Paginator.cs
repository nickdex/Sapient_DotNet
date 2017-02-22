using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApplication.Utilities
{
    public class Paginator
    {
        private byte _pageSize = 3;
        private byte startNumber = 1;
        private int _count;
        private List<string> _indexList;
        private int _skipCount;

        #region Properties
        public int TotalPages
        {
            get
            {
                return _count;
            }
        }

        public List<string> IndexList
        {
            get
            {
                return _indexList;
            }
        }

        public int SkipCount
        {
            get
            {
                return _skipCount;
            }
        }

        public byte PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        } 
        #endregion

        public Paginator(int count)
        {
            _count = count;
            var intList = Enumerable.Range(startNumber, _count / _pageSize).ToList();
            _indexList = intList.Select(i => Convert.ToString(i)).ToList<string>();
        }

        internal void Calculate(int id)
        {
            if (id <= 0 || id > _count)
            {
                _skipCount = 1;
            }

            _skipCount = (id - 1) * _pageSize;
        }
    }
}